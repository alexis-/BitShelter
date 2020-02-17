using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public partial class SnapshotRule
  {
    [DataMember]
    public long Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public bool Enabled { get; set; }


    //
    // Overrides

    public override bool Equals(object obj)
    {
      if (!(obj is SnapshotRule))
        return false;

      return Id.Equals(((SnapshotRule)obj).Id);
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }

    public override string ToString()
    {
      return $"[#{Id}] {Name}: {ScheduleDescription}";
    }
  }
}
