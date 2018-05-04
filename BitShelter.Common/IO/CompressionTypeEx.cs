extern alias sc;

using sc::SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.IO
{
  public static class CompressionTypeEx
  {
    public static IEnumerable<CompressionType> GetAvailableCompressions(this ArchiveType archiveType)
    {
      switch (archiveType)
      {
        case ArchiveType.Tar:
          return new List<CompressionType>()
          {
            CompressionType.None,
            CompressionType.BZip2,
            CompressionType.GZip,
            CompressionType.LZip,
          };

        case ArchiveType.Zip:
          return new List<CompressionType>()
          {
            CompressionType.None,
            CompressionType.BZip2,
            CompressionType.Deflate,
            CompressionType.PPMd,
          };

        default:
          throw new ArgumentException(String.Format("ArchiveType {0} not supported", (int)archiveType), "archiveType");
      }
    }
  }
}
