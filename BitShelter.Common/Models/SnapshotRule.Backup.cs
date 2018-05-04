using BitShelter.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BitShelter.Models
{
  partial class SnapshotRule
  {
    [DataMember]
    public bool BackupEnabled { get; set; }
    [DataMember]
    public List<BackupRule> BackupRules { get; set; } = new List<BackupRule>();
    [DataMember]
    public int BackupTotalMaxSize { get; set; }
    [DataMember]
    [JsonConverter(typeof(StringEnumConverter))]
    public MediumStorageUnit BackupTotalMaxSizeUnit { get; set; }
    [DataMember]
    public bool BackupNotify { get; set; }
  }
}
