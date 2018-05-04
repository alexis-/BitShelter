using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models.Enums
{
  [DataContract]
  public enum StorageUnit : long
  {
    [EnumMember]
    B = 1,
    [EnumMember]
    KB = 1024,
    [EnumMember]
    MB = 1048576,
    [EnumMember]
    GB = 1073741824,
    [EnumMember]
    TB = 1099511627776
  }

  [DataContract]
  public enum SmallStorageUnit : long
  {
    [EnumMember]
    KB = 1024,
    [EnumMember]
    MB = 1048576,
    [EnumMember]
    GB = 1073741824,
    [EnumMember]
    TB = 1099511627776
  }

  [DataContract]
  public enum MediumStorageUnit : long
  {
    [EnumMember]
    MB = 1048576,
    [EnumMember]
    GB = 1073741824,
    [EnumMember]
    TB = 1099511627776
  }

  [DataContract]
  public enum LargeStorageUnit : long
  {
    [EnumMember]
    GB = 1073741824,
    [EnumMember]
    TB = 1099511627776
  }
}
