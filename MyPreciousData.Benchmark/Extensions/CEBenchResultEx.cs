using MyPreciousData.Benchmark.Models;
using MyPreciousData.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Benchmark.Extensions
{
  public static class CEBenchResultEx
  {
    public static void Print(this CEBenchResult res, int iterations)
    {
      Console.WriteLine(
        "{0}.{1} ({2} - {3})\n------------------------------------------------\nTotal: {4}ms\nMean: {5}ms\nCompressed size: {6}\n\n",
        res.ArchiveType.ToString(), res.CompressionType.ToString(),
        res.EncryptionProtocol.ToString(), res.EncryptionAlgorithm.GetDisplayName(),
        res.TotalRuntime, res.TotalRuntime / iterations,
        res.CompressedSize);
    }
  }
}
