using System;

namespace MyPreciousData.Models
{
  public class SnapshotInstance
  {
    public Guid SnapshotId { get; set; }
    public long SnapshotRuleId { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}
