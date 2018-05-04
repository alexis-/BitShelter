using Alphaleonis.Win32.Vss;
using BitShelter.Models;
using BitShelter.Service.Config;
using BitShelter.Service.Scheduler;
using BitShelter.Utils;
using BitShelter.VSS;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace BitShelter.Service.Data
{
  public delegate void RulesUpdated(IEnumerable<SnapshotRule> rules);

  public class RuleMgr
  {
    protected ConcurrentDictionary<long, SnapshotRule> RulesMap { get; set; }

    protected RuleMgr()
    {

    }

    protected static RuleMgr _instance = null;
    public static RuleMgr Instance => _instance ?? (_instance = new RuleMgr());

    public void LoadRules(IList<SnapshotRule> rules)
    {
      RulesMap = rules.ToConcurrentDictionary(k => k.Id);

      VssScheduler.CreateAllTriggers(Rules);
    }

    public void AddOrUpdateRule(SnapshotRule newRule)
    {
      SnapshotRule oldRule = RulesMap.SafeGet(newRule.Id);

      if (oldRule != null)
        newRule.CopyProperties(oldRule);

      else
        RulesMap[newRule.Id] = newRule;

      SaveRules();

      VssScheduler.CreateAllTriggers(Rules);
    }

    public bool DeleteRule(SnapshotRule rule, bool deleteSnapshots)
    {
      rule.Enabled = false;

      if (deleteSnapshots)
        using (var vss = new VssClient(new VssHost()))
        {
          vss.Initialize(VssSnapshotContext.All, VssBackupType.Incremental);
          PruningMgr.Instance.DeleteAllForRule(vss, rule);
        }

      bool ret = RulesMap.TryRemove(rule.Id, out SnapshotRule value);

      if (!ret)
        return false;

      VssScheduler.CreateAllTriggers(Rules);

      SaveRules();

      return ret;
    }

    public void SaveRules()
    {
      ConfigMgr.Instance.SaveRules(Rules);
    }

    public SnapshotRule GetRule(long ruleId) => RulesMap.SafeGet(ruleId);
    public IEnumerable<SnapshotRule> Rules => RulesMap.Values;
  }
}
