using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public enum Freq
  {
    [EnumMember]
    Daily,
    [EnumMember]
    Weekly,
    [EnumMember]
    Monthly,
    [EnumMember]
    Cron,
    [EnumMember]
    Unknown
  }
}
