using System.Runtime.Serialization;

namespace BitShelter.Models.Enums
{
  [DataContract]
  public enum Timespan
  {
    [EnumMember]
    Minute = 60,
    [EnumMember]
    Hour = 3600,
    [EnumMember]
    Day = 86400,
    [EnumMember]
    Week = 604800,
    [EnumMember]
    Month = 2628000, // Averaged at (Year / 12)
    [EnumMember]
    Year = 31536000 // Day * 365
  }
}
