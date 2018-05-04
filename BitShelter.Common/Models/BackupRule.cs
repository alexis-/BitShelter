//Conflicting Org.BouncyCastle definitions
extern alias sc;

using sc::SharpCompress.Common;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BitShelter.Models
{
  [DataContract]
  public class BackupRule
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public HashSet<string> InputFolders { get; set; }
    [DataMember]
    public string OutputFolder { get; set; }

    [DataMember]
    public HashSet<PathFilter> FilterIncludes { get; set; }
    [DataMember]
    public HashSet<PathFilter> FilterExcludes { get; set; }

    [DataMember]
    public int Offset { get; set; }
    [DataMember]
    public int Every { get; set; }

    [DataMember]
    public int MaxSizeMB { get; set; }
    [DataMember]
    public int MaxBackupCount { get; set; }

    [DataMember]
    public bool CompressionEnabled { get; set; }
    [DataMember]
    public ArchiveType ArchiveType { get; set; }
    [DataMember]
    public CompressionType CompressionType { get; set; }
    [DataMember]
    public EncryptionAlgorithm EncryptionType { get; set; }

    [DataMember]
    public bool NotifyError { get; set; }
    [DataMember]
    public bool NotifyComplete { get; set; }
  }
}
