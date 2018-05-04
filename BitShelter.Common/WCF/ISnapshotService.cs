using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.WCF
{
  [ServiceContract(CallbackContract = typeof(ISnapshotServiceCallback))]
  public interface ISnapshotService
  {
    [OperationContract]
    IEnumerable<SnapshotRule> GetRules();

    [OperationContract]
    bool AddOrUpdateRule(SnapshotRule rule);

    [OperationContract]
    bool DeleteRule(SnapshotRule rule, bool deleteSnapshots);
  }

  [ServiceContract]
  public interface ISnapshotServiceCallback
  {
    [OperationContract]
    void Dummy();
  }
}
