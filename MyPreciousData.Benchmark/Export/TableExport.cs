using MyPreciousData.Benchmark.Models;
using MyPreciousData.Encryption;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Benchmark.Export
{
  public class TableExport
  {
    protected IEnumerable<CEBenchResult> Results { get; }
    public int OriginalSize { get; }
    public int Iterations { get; }

    public TableExport(IEnumerable<CEBenchResult> results, int originalSize, int iterations)
    {
      Results = results;
      OriginalSize = originalSize;
      Iterations = iterations;
    }

    public void ExportXls(string filepath)
    {
      IWorkbook workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();

      Export(workbook, filepath);

      workbook.Close();
    }

    private void Export(IWorkbook workbook, string filepath)
    {
      ISheet sheet = workbook.CreateSheet(
        String.Format(
          "Benchmark {0}",
          DateTime.Now.ToShortDateString()
        )
      );

      int rowNum = 0;

      // Create header
      IRow headerRow = sheet.CreateRow(rowNum);
      headerRow.CreateCell(0).SetCellValue("Archive");
      headerRow.CreateCell(1).SetCellValue("Compression");
      headerRow.CreateCell(2).SetCellValue("Protocol");
      headerRow.CreateCell(3).SetCellValue("Algorithm");
      headerRow.CreateCell(4).SetCellValue("Compressed Size");
      headerRow.CreateCell(5).SetCellValue("Compression Ratio");
      headerRow.CreateCell(6).SetCellValue("Total Runtime");
      headerRow.CreateCell(7).SetCellValue("Mean Runtime");
      headerRow.CreateCell(8).SetCellValue("Median Runtime");

      foreach (var res in Results)
      {
        IRow row = sheet.CreateRow(++rowNum);

        row.CreateCell(0).SetCellValue(res.ArchiveType.ToString());
        row.CreateCell(1).SetCellValue(res.CompressionType.ToString());
        row.CreateCell(2).SetCellValue(res.EncryptionProtocol.ToString());
        row.CreateCell(3).SetCellValue(res.EncryptionAlgorithm.GetDisplayName());
        row.CreateCell(4).SetCellValue(res.CompressedSize);
        row.CreateCell(5).SetCellValue(String.Format("{0}%", res.CompressedSize == 0 ? 100 : (double)res.CompressedSize / (double)OriginalSize * 100d));
        row.CreateCell(6).SetCellValue(res.TotalRuntime);
        row.CreateCell(7).SetCellValue(res.TotalRuntime / Iterations);
        row.CreateCell(8).SetCellValue(0);
      }

      using (Stream outStream = File.OpenWrite(filepath))
        workbook.Write(outStream);
    }
  }
}
