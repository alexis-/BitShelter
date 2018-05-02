using Alphaleonis.Win32.Vss;
using MyPreciousData.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models
{
  partial class SnapshotRule
  {
    public int LifeTimeValue { get; set; }
    public Timespan LifeTimeUnit { get; set; }
    public DriveList Volumes { get; set; } = new DriveList();
    public string VolumesAsString => Volumes?.ToString();

    public VssSnapshotContext VssContext { get; set; } = VssSnapshotContext.ClientAccessible;
    public VssBackupType VssBackupType { get; set; } = VssBackupType.Incremental;

    public List<string> VssIncludeWriters { get; set; } = new List<string>();
    public List<string> VssExcludeWriters { get; set; } = new List<string>();

    public int MaxRetryCount { get; set; }
    public bool RetryRestartVSSService { get; set; }

    public int ChecksumCanary { get; set; }
    public bool ChecksumFiles { get; set; }
    public HashSet<PathFilter> ChecksumFileIncludes { get; set; } = new HashSet<PathFilter>();
    public HashSet<PathFilter> ChecksumFileExcludes { get; set; } = new HashSet<PathFilter>();
  }
}
