using MyPreciousData.Benchmark.Export;
using MyPreciousData.Benchmark.Extensions;
using MyPreciousData.Benchmark.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Benchmark.Console
{
  // https://catchchallenger.first-world.info/wiki/Quick_Benchmark:_Gzip_vs_Bzip2_vs_LZMA_vs_XZ_vs_LZ4_vs_LZO
  class Program
  {
    static void Main(string[] args)
    {
      const int iterations = 1;
      const int sizeMB = 5;
      const int sizeB = 5 * 1024 * 1024;

      //var summary = BenchmarkRunner.Run<CompressAndEncryptBenchmark>();
      IEnumerable<CEBenchResult> results;

      using (Stream inStream = new MemoryStream(BenchmarkHelper.GenerateRandomData(sizeMB), 0, sizeB))
        results = CompressAndEncryptBenchmark.Run(inStream, iterations);

      foreach (var res in results)
        res.Print(iterations);

      new TableExport(results, sizeB, iterations)
        .ExportXls(Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
          String.Format("MyPreciousData_Bench_{0}.xls", DateTime.Now.Ticks)
        ));

      System.Console.ReadKey();
    }
  }
}
