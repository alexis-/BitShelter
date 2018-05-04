using BitShelter.Models;
using BitShelter.Service.Data;
using BitShelter.WCF;
using Serilog;
using System;
using System.Collections.Generic;

namespace BitShelter.Service.WCF
{
  //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant, ReleaseServiceInstanceOnTransactionComplete = false)]
  public class SnapshotService : ISnapshotService
  {
    public bool AddOrUpdateRule(SnapshotRule rule)
    {
      try
      {
        RuleMgr.Instance.AddOrUpdateRule(rule);

        return true;
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed to add/update rule {Id}", rule?.Id);

        return false;
      }
    }

    public bool DeleteRule(SnapshotRule rule, bool deleteSnapshots)
    {
      try
      {
        return RuleMgr.Instance.DeleteRule(rule, deleteSnapshots);
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed to delete rule {Id}", rule?.Id);

        return false;
      }
    }

    public IEnumerable<SnapshotRule> GetRules()
    {
      return RuleMgr.Instance.Rules;
    }
  }
}
