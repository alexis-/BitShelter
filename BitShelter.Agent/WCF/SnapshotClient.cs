using BitShelter.Models;
using BitShelter.WCF;
using System.Collections.Generic;
using System.ServiceModel;

namespace BitShelter.Agent.WCF
{
  public class SnapshotClient : DuplexClientBase<ISnapshotService>, ISnapshotService
  {
    public SnapshotClient(InstanceContext instanceContext) : base(instanceContext)
    {
    }

    public bool AddOrUpdateRule(SnapshotRule rule)
    {
      return Channel.AddOrUpdateRule(rule);
    }

    public bool DeleteRule(SnapshotRule rule, bool deleteSnapshots)
    {
      return Channel.DeleteRule(rule, deleteSnapshots);
    }

    public IEnumerable<SnapshotRule> GetRules()
    {
      return Channel.GetRules();
    }
  }
}
