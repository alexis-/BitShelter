using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models.Enums
{
  [DataContract]
  public enum SnapshotType
  {
    [EnumMember]
    Full,
    [EnumMember]
    Differential,
    [EnumMember]
    Incremental,
  }
}
