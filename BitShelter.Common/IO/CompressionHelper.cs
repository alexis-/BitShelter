//Conflicting Org.BouncyCastle definitions
extern alias sc;

using sc::SharpCompress.Common;
using sc::SharpCompress.Writers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BitShelter.IO
{
  public static class CompressionHelper
  {
    public static IEnumerable<ArchiveType> AvailableArchives =>
      new List<ArchiveType>()
      {
        ArchiveType.Tar,
        ArchiveType.Zip,
      };

    public static void Compress(
      string rootDir,
      IEnumerable<FileInfo> files,
      Stream outStream,
      ArchiveType archiveType,
      CompressionType compressionType,
      ProgressStreamReportDelegate progressCallback)
    {
      char[] dirSeparators = { '\\', '/' };

      if (progressCallback != null)
      {
        outStream = new ProgressStream(outStream);
        ((ProgressStream)outStream).BytesWritten += progressCallback;
      }

      int rootDirLen = rootDir.Length + (dirSeparators.Contains(rootDir.Last()) ? 0 : 1);

      using (var writer = WriterFactory.Open(outStream, archiveType, new WriterOptions(compressionType)))
      {
        foreach (FileInfo f in files)
          writer.Write(f.FullName.Substring(rootDirLen), f);
      }

      if (progressCallback != null)
        ((ProgressStream)outStream).BytesWritten -= progressCallback;
    }

    public static void Compress(
      string entryPath,
      Stream inStream,
      Stream outStream,
      ArchiveType archiveType,
      CompressionType compressionType,
      ProgressStreamReportDelegate progressCallback)
    {
      char[] dirSeparators = { '\\', '/' };

      if (progressCallback != null)
      {
        outStream = new ProgressStream(outStream);
        ((ProgressStream)outStream).BytesWritten += progressCallback;
      }

      using (var writer = WriterFactory.Open(outStream, archiveType, new WriterOptions(compressionType)))
      {
        writer.Write(entryPath, inStream);
      }

      if (progressCallback != null)
        ((ProgressStream)outStream).BytesWritten -= progressCallback;
    }
  }
}
