using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public enum VssBackupTypeInternal : uint
  {
    [EnumMember]
    Undefined = 0,
    [EnumMember]
    Full = 1,
    [EnumMember]
    Incremental = 2,
    [EnumMember]
    Differential = 3,
    [EnumMember]
    Log = 4,
    [EnumMember]
    Copy = 5,
    [EnumMember]
    Other = 6
  }
}
