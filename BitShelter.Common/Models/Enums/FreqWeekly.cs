using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public enum FreqWeekly
  {
    [EnumMember]
    Weekly,
    [EnumMember]
    OnDays,
    [EnumMember]
    Unknown
  }
}
