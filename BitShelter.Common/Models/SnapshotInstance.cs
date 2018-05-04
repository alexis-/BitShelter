using System;
using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public class SnapshotInstance
  {
    [DataMember]
    public Guid SnapshotId { get; set; }
    [DataMember]
    public long SnapshotRuleId { get; set; }
    [DataMember]
    public DateTime CreatedAt { get; set; }
  }
}
