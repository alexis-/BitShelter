using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Benchmark
{
  public static class BenchmarkHelper
  {
    public static byte[] GenerateRandomData(int sizeMB)
    {
      Random rng = new Random();
      byte[] data = new byte[sizeMB * 1024 * 1024];

      rng.NextBytes(data);

      return data;
    }
  }
}
