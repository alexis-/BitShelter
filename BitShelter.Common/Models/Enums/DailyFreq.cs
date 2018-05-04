using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public enum DailyFreq
  {
    [EnumMember]
    Once,
    [EnumMember]
    Every,
    [EnumMember]
    Unknown
  }
}
