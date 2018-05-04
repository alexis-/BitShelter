using BitShelter.Models;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Benchmark.Models
{
  public class CEBenchResult
  {
    public ArchiveType ArchiveType { get; set; }
    public CompressionType CompressionType { get; set; }
    public EncryptionProtocol EncryptionProtocol { get; set; }
    public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

    public long CompressedSize { get; set; }
    public long TotalRuntime { get; set; }
  }
}
