using MyPreciousData.Benchmark.Models;
using MyPreciousData.Encryption;
using MyPreciousData.IO;
using MyPreciousData.Models;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MyPreciousData.Benchmark
{
  public static class CompressAndEncryptBenchmark
  {
    public static IEnumerable<CEBenchResult> Run(
    Stream inStream, int iterationNb, ProgressStreamReportDelegate inReadCallback)
    {
      if (inReadCallback != null)
      {
        inStream = new ProgressStream(inStream);
        ((ProgressStream)inStream).BytesRead += inReadCallback;
      }

      var ret = Run(inStream, iterationNb);

      if (inReadCallback != null)
        ((ProgressStream)inStream).BytesRead -= inReadCallback;

      return ret;
    }

    public static IEnumerable<CEBenchResult> Run(Stream inStream, int iterationNb)
    {
      List<CEBenchResult> ret = new List<CEBenchResult>();
      Stopwatch sw = new Stopwatch();


      foreach (ArchiveType at in CompressionHelper.AvailableArchives)
      {
        foreach (CompressionType ct in at.GetAvailableCompressions())
        {
          foreach (EncryptionProtocol ep in EncryptionHelper.AvailableProtocols)
          {
            foreach (EncryptionAlgorithm ea in ep.GetAvailableAlgorithms())
            {
              long compSize = 0;

              sw.Reset();
              sw.Start();

              for (int i = 0; i < iterationNb; i++)
              {


                inStream.Seek(0, SeekOrigin.Begin);
                compSize = Process(inStream, at, ct, ep, ea);
              }

              sw.Stop();

              ret.Add(new CEBenchResult()
              {
                ArchiveType = at,
                CompressionType = ct,
                EncryptionProtocol = ep,
                EncryptionAlgorithm = ea,
                TotalRuntime = sw.ElapsedMilliseconds,
                CompressedSize = compSize
              });
            }
          }
        }
      }

      return ret;
    }

    public static long Process(
      Stream data,
      ArchiveType archiveType, CompressionType compType,
      EncryptionProtocol encProtocol, EncryptionAlgorithm encAlgorithm)
    {
      string fileName = Path.GetTempFileName();
      FileInfo fileInfo = new FileInfo(fileName);
      long compSizeB = 0;

      ProgressStreamReportDelegate progressCallback =
        (_, args) => compSizeB += args.BytesMoved;

      using (Stream outFileStream = fileInfo.OpenWrite())
      {
        Action<Stream> streamWriter =
          (outStream) => CompressionHelper.Compress(
            "data.bin",
            data,
            outStream,
            archiveType,
            compType,
            progressCallback
          );

        switch (encProtocol)
        {
          case EncryptionProtocol.None:
            streamWriter(outFileStream);
            break;

          case EncryptionProtocol.AES:
            EncryptionHelper.EncryptStreamAES(streamWriter, outFileStream, encAlgorithm, Const.EncKey32);
            break;

          case EncryptionProtocol.PBE:
            EncryptionHelper.EncryptStreamPBE(streamWriter, outFileStream, encAlgorithm, Const.EncKey32);
            break;

          case EncryptionProtocol.PGP:
            using (Stream pgpPubKeyStream = new MemoryStream(Encoding.ASCII.GetBytes(Const.PGPPubKey)))
            EncryptionHelper.EncryptStreamPGP(
              streamWriter, outFileStream, encAlgorithm,
              pgpPubKeyStream, Convert.ToInt64(Const.PGPPubKeyID, 16));
            break;
        }
      }

      fileInfo.Delete();

      return compSizeB;
    }
  }
}
