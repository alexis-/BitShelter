using Alphaleonis.Win32.Vss;
using BitShelter.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models
{
  partial class SnapshotRule
  {
    [DataMember]
    public int LifeTimeValue { get; set; }
    [DataMember]
    public Timespan LifeTimeUnit { get; set; }
    [DataMember]
    public List<string> Volumes { get; set; } = new List<string>();
    
    public string VolumesAsString => String.Join(",",
        BitShelter.Utils.Volumes.GetVolumesForDevicesID(Volumes)
        .Select(v => v.ToShortString())
      );

    [DataMember]
    public VssSnapshotContextInternal VssContext { get; set; } = VssSnapshotContextInternal.ClientAccessible;
    [DataMember]
    public VssBackupTypeInternal VssBackupType { get; set; } = VssBackupTypeInternal.Incremental;

    [DataMember]
    public List<string> VssIncludeWriters { get; set; } = new List<string>();
    [DataMember]
    public List<string> VssExcludeWriters { get; set; } = new List<string>();

    [DataMember]
    public int MaxRetryCount { get; set; }
    [DataMember]
    public bool RetryRestartVSSService { get; set; }

    [DataMember]
    public int ChecksumCanary { get; set; }
    [DataMember]
    public bool ChecksumFiles { get; set; }
    [DataMember]
    public HashSet<PathFilter> ChecksumFileIncludes { get; set; } = new HashSet<PathFilter>();
    [DataMember]
    public HashSet<PathFilter> ChecksumFileExcludes { get; set; } = new HashSet<PathFilter>();
  }
}
