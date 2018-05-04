using BitShelter.Data;
using BitShelter.Models;
using BitShelter.Service.Data;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BitShelter.Service.Config
{
  public class ConfigMgr
  {
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
    }

    public void SaveRules(IEnumerable<SnapshotRule> rules)
    {
      string fileName = String.Format("rule_{0}.json", DateTime.Now.Ticks);

      ConfigLoader.SaveToFile(rules, fileName);
    }
  }
}
