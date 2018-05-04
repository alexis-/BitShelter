using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models
{
  [DataContract]
  public enum FilterMode
  {
    [EnumMember]
    Include,
    [EnumMember]
    Exclude,
    [EnumMember]
    Unknown,
  }
}
