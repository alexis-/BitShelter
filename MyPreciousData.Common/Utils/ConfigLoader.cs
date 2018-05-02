using MyPreciousData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPreciousData.Utils
{
  public static class ConfigLoader
  {
    public const string AppConfigFileName = "appconfig.json";
    public const string SnapshotInstancesFileName = "instances.json";
    public const string RuleFileNameRegexPattern = "rule_([0-9]+)\\.json";
    public static readonly Regex RuleFileNameRegex = new Regex(RuleFileNameRegexPattern);



    //
    // Load methods

    public static async Task<AppConfig> LoadAppConfig()
    {
      string appConfigFilePath = GetAppConfigPath();

      return await SafeLoadJson<AppConfig>(appConfigFilePath);
    }

    public static async Task<IEnumerable<SnapshotInstance>> LoadSnapshotInstances()
    {
      string snapshotInstancesFilePath = GetSnapshotInstancesFilePath();

      return await SafeLoadJson<IEnumerable<SnapshotInstance>>(snapshotInstancesFilePath);
    }

    public static async Task<Tuple<IList<SnapshotRule>, string>> LoadLatestRules()
    {
      string appData = GetAppDataFolderPath();
      string latestRulesFileName = GetLatestRulesFileName(appData);

      IList<SnapshotRule> rules = latestRulesFileName == null
        ? new List<SnapshotRule>()
        : (await SafeLoadJson<IEnumerable<SnapshotRule>>(Path.Combine(appData, latestRulesFileName))).ToList();

      return new Tuple<IList<SnapshotRule>, string>(
        rules,
        latestRulesFileName
      );
    }

    public static async Task<SnapshotRule> LoadRules(string rulesFileName)
    {
      string rulesFilePath = GetRulesPath(rulesFileName);

      return await SafeLoadJson<SnapshotRule>(rulesFilePath);
    }

    public static async Task<T> SafeLoadJson<T>(string filePath)
    {
      if (filePath != null && File.Exists(filePath))
        using (var reader = File.OpenText(filePath))
          return JsonConvert.DeserializeObject<T>(await reader.ReadToEndAsync());

      return default(T);
    }

    public static void SaveToFile<T>(T obj, string fileName)
    {
      using (Stream s = File.Open(GetRulesPath(fileName), FileMode.Create, FileAccess.Write))
      using (StreamWriter sw = new StreamWriter(s))
      {
        string json = JsonConvert.SerializeObject(obj);
        sw.Write(json);
      }
    }



    //
    // Path computing methods

    public static string GetAppDataFolderPath()
    {
      return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Const.AppName);
    }

    public static string GetAppConfigPath()
    {
      string appData = GetAppDataFolderPath();

      return Path.Combine(appData, AppConfigFileName);
    }

    public static string GetSnapshotInstancesFilePath()
    {
      string appData = GetAppDataFolderPath();

      return Path.Combine(appData, SnapshotInstancesFileName);
    }

    public static string GetRulesPath(string rulesFileName)
    {
      string appData = GetAppDataFolderPath();

      if (rulesFileName == null)
        return null;

      return Path.Combine(appData, rulesFileName);
    }

    public static string GetLatestRulesFileName(string rootFolderPath)
    {
      return GetAllRulesFileName(rootFolderPath)
        .FirstOrDefault();
    }

    public static IEnumerable<string> GetAllRulesFileName(string rootFolderPath)
    {
      return Directory.GetFiles(rootFolderPath)
        .Where(f => IsRulesFileName(f))
        .OrderByDescending(f => GetRulesTimestampFromFileName(f));
    }

    public static bool IsRulesFileName(string fileName)
    {
      return String.IsNullOrWhiteSpace(fileName)
        ? false
        : RuleFileNameRegex.Match(fileName).Success;
    }

    public static long GetRulesTimestampFromFileName(string fileName)
    {
      return String.IsNullOrWhiteSpace(fileName)
        ? -1
        : Int64.Parse(RuleFileNameRegex.Match(fileName).Groups[1].Value);
    }
  }
}
