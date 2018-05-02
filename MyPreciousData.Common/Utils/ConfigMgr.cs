using MyPreciousData.Data;
using MyPreciousData.Models;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyPreciousData.Utils
{
  public class ConfigMgr
  {
    private FileSystemWatcher Watcher { get; set; }
    private RulesConfigModified RulesConfigModifiedCallback { get; set; }
    private string LoadedRulesFileName { get; set; }

    protected static ConfigMgr _instance;
    public static ConfigMgr Instance => _instance ?? (_instance = new ConfigMgr());

    protected ConfigMgr() { }



    //
    //

    public void Initialize(IAppHost appHost)
    {
      //_appConfig = ConfigLoader.LoadAppConfig().Result ?? new AppConfig();

      PruningMgr.Instance.LoadInstances(ConfigLoader.LoadSnapshotInstances().Result ?? new List<SnapshotInstance>());

      Tuple<IList<SnapshotRule>, string> ret = ConfigLoader.LoadLatestRules().Result;
      RuleMgr.Instance.LoadRules(ret.Item1 ?? new List<SnapshotRule>());
      LoadedRulesFileName = ret.Item2;

      if ((RulesConfigModifiedCallback = appHost.GetRulesConfigModifiedCallback()) != null)
        StartFolderWatch();
    }

    public void Shutdown()
    {
      StopFolderWatch();
    }

    public void SaveRules(IEnumerable<SnapshotRule> rules)
    {
      string fileName = String.Format("rule_{0}.json", DateTime.Now.Ticks);

      ConfigLoader.SaveToFile(rules, fileName);
    }

    //public void SaveAppConfig()
    //{
    //  ConfigLoader.SaveToFile(AppConfig, ConfigLoader.AppConfigFileName);
    //}

    private void StartFolderWatch()
    {
      if (Watcher != null)
        StopFolderWatch();

      Watcher = new FileSystemWatcher();

      Watcher.Path = ConfigLoader.GetAppDataFolderPath();
      Watcher.NotifyFilter = NotifyFilters.LastWrite;
      Watcher.Filter = "*.*";
      Watcher.Changed += OnFolderChange;
      Watcher.EnableRaisingEvents = true;
    }

    private void StopFolderWatch()
    {
      if (Watcher != null)
      {
        Watcher.EnableRaisingEvents = false;
        Watcher.Changed -= OnFolderChange;
        Watcher.Dispose();
        Watcher = null;
      }
    }

    private void OnFolderChange(object sender, FileSystemEventArgs ev)
    {
      if (ConfigLoader.IsRulesFileName(ev.Name) == false)
        return;

      // Compare last file name
      var ret = ConfigLoader.LoadLatestRules().Result;

      if (ret.Item1 == null || String.IsNullOrWhiteSpace(ret.Item2))
        return;

      IList<SnapshotRule> newRules = ret.Item1;
      string newRulesFileName = ret.Item2;

      long newRulesTimestamp = ConfigLoader.GetRulesTimestampFromFileName(newRulesFileName);
      long oldRulesTimestamp = ConfigLoader.GetRulesTimestampFromFileName(LoadedRulesFileName);

      if (newRulesTimestamp > oldRulesTimestamp)
      {
        LoadedRulesFileName = newRulesFileName;
        RulesConfigModifiedCallback(newRules);
      }
    }

    //private AppConfig _appConfig;
    //public static AppConfig AppConfig => Instance._appConfig;
  }
}
