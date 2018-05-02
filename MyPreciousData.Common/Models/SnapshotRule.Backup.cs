using MyPreciousData.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace MyPreciousData.Models
{
  partial class SnapshotRule
  {
    public bool BackupEnabled { get; set; }
    public List<BackupRule> BackupRules { get; set; } = new List<BackupRule>();
    public int BackupTotalMaxSize { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public MediumStorageUnit BackupTotalMaxSizeUnit { get; set; }
    public bool BackupNotify { get; set; }
  }
}
