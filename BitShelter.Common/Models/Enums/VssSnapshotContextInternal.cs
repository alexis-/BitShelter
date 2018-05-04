using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public enum VssSnapshotContextInternal : uint
  {
    [EnumMember]
    Backup = 0,
    [EnumMember]
    AppRollback = 9,
    [EnumMember]
    ClientAccessibleWriters = 13,
    [EnumMember]
    FileShareBackup = 16,
    [EnumMember]
    NasRollback = 25,
    [EnumMember]
    ClientAccessible = 29,
    [EnumMember]
    All = uint.MaxValue
  }
}
