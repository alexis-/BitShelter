//Conflicting Org.BouncyCastle definitions
extern alias sc;

using sc::SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models
{
  public class BackupRule
  {
    public string Name { get; set; }

    public HashSet<string> InputFolders { get; set; }
    public string OutputFolder { get; set; }

    public HashSet<PathFilter> FilterIncludes { get; set; }
    public HashSet<PathFilter> FilterExcludes { get; set; }

    public int Offset { get; set; }
    public int Every { get; set; }

    public int MaxSizeMB { get; set; }
    public int MaxBackupCount { get; set; }

    public bool CompressionEnabled { get; set; }
    public ArchiveType ArchiveType { get; set; }
    public CompressionType CompressionType { get; set; }
    public EncryptionAlgorithm EncryptionType { get; set; }

    public bool NotifyError { get; set; }
    public bool NotifyComplete { get; set; }
  }
}
