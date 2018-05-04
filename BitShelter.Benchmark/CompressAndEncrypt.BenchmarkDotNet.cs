#if false
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Configs;
using BitShelter.Encryption;
using BitShelter.IO;
using BitShelter.Models;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitShelter.Benchmark
{
  [ShortRunJob]
  public class CompressAndEncryptBenchmark
  {
    const string EncKey = "R>Hb4J&N0S36c{|'H:-vssgy8{Ae@0E_";

    private byte[] Data;

    [Params(64)]
    public int SizeMB;

    [Benchmark(Baseline = true)]
    public void FilePlain()
    {
      string fileName = Path.GetTempFileName();
      File.WriteAllBytes(fileName, Data);
      File.Delete(fileName);
    }


    //
    // Tar.* | NoProto | NoEnc
    [BenchmarkCategory("Tar", "NoComp", "NoProto", "NoEnc")]
    [Benchmark]
    public void TarPlain() => Process(ArchiveType.Tar, CompressionType.None, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Tar", "BZip2", "NoProto", "NoEnc")]
    [Benchmark]
    public void TarBZip2() => Process(ArchiveType.Tar, CompressionType.BZip2, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Tar", "GZip", "NoProto", "NoEnc")]
    [Benchmark]
    public void TarGZip() => Process(ArchiveType.Tar, CompressionType.GZip, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Tar", "LZip", "NoProto", "NoEnc")]
    [Benchmark]
    public void TarLZip() => Process(ArchiveType.Tar, CompressionType.LZip, EncryptionProtocol.None, EncryptionAlgorithm.None);


    //
    // Zip.* | NoProto | NoEnc
    [BenchmarkCategory("Zip", "NoComp", "NoProto", "NoEnc")]
    [Benchmark]
    public void ZipPlain() => Process(ArchiveType.Tar, CompressionType.None, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Zip", "BZip2", "NoProto", "NoEnc")]
    [Benchmark]
    public void ZipBZip2() => Process(ArchiveType.Tar, CompressionType.BZip2, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Zip", "GZip", "NoProto", "NoEnc")]
    [Benchmark]
    public void ZipGZip() => Process(ArchiveType.Tar, CompressionType.GZip, EncryptionProtocol.None, EncryptionAlgorithm.None);
    [BenchmarkCategory("Zip", "PPMd", "NoProto", "NoEnc")]
    [Benchmark]
    public void ZipPPMd() => Process(ArchiveType.Tar, CompressionType.PPMd, EncryptionProtocol.None, EncryptionAlgorithm.None);


    //
    // Tar.* | AES | AES128-CBC
    //[BenchmarkCategory("Tar", "NoComp", "AES", "NoEnc")]
    //[Benchmark]
    //public void TarPlainAES128CBC() => Process(ArchiveType.Tar, CompressionType.None, EncryptionProtocol.None, EncryptionAlgorithm.None);
    //[BenchmarkCategory("Tar", "BZip2", "AES", "NoEnc")]
    //[Benchmark]
    //public void TarBZip2AES128CBC() => Process(ArchiveType.Tar, CompressionType.BZip2, EncryptionProtocol.None, EncryptionAlgorithm.None);
    //[BenchmarkCategory("Tar", "GZip", "AES", "NoEnc")]
    //[Benchmark]
    //public void TarGZipAES128CBC() => Process(ArchiveType.Tar, CompressionType.GZip, EncryptionProtocol.None, EncryptionAlgorithm.None);
    //[BenchmarkCategory("Tar", "LZip", "AES", "NoEnc")]
    //[Benchmark]
    //public void TarLZipAES128CBC() => Process(ArchiveType.Tar, CompressionType.LZip, EncryptionProtocol.None, EncryptionAlgorithm.None);


    private void Process(
      ArchiveType archiveType, CompressionType compType,
      EncryptionProtocol encProtocol, EncryptionAlgorithm encAlgorithm)
    {
      string fileName = Path.GetTempFileName();
      FileInfo fileInfo = new FileInfo(fileName);

      using (Stream outFileStream = fileInfo.OpenWrite())
      {
        Action<Stream> streamWriter =
          (outStream) => CompressionHelper.Compress(
            "data.bin",
            Data,
            outStream,
            archiveType,
            compType,
            null
          );

        switch (encProtocol)
        {
          case EncryptionProtocol.None:
            streamWriter(outFileStream);
            break;

          case EncryptionProtocol.AES:
            EncryptionHelper.EncryptStreamAES(streamWriter, outFileStream, encAlgorithm, EncKey);
            break;

          case EncryptionProtocol.PBE:
            EncryptionHelper.EncryptStreamPBE(streamWriter, outFileStream, encAlgorithm, EncKey);
            break;
        }
      }

      fileInfo.Delete();
    }

    [GlobalSetup]
    public void Setup()
    {
      Data = BenchmarkHelper.GenerateRandomData(SizeMB);
    }

    private class Config : ManualConfig
    {
      public Config()
      {

      }
    }
  }
}

#endif