using Alphaleonis.Win32.Vss;
using MyPreciousData.Utils;
using MyPreciousData.VSS;
using Newtonsoft.Json;
using Serilog;
using Serilog.Events;
using System.Collections.Generic;
using System.Linq;

namespace MyPreciousData.Console
{
  class Program
  {
    static void Main(string[] args)
    {
      AppInit.Initialize(new DefaultAppHost());
      Logger.Instance.SetMinimumLevel(LogEventLevel.Verbose);

      string eDrive = "\\\\?\\Volume{4dfaa856-0000-0000-0000-100000000000}\\";
      string fDrive = "\\\\?\\Volume{39f6508a-0000-0000-0000-90032e000000}\\";

      var host = new VssHost();
      using (VssClient vss = new VssClient(host))
      {
        vss.Initialize(VssSnapshotContext.ClientAccessible, VssBackupType.Incremental);
        //vss.CreateSnapshot(new List<string>() { fDrive }, null, new List<string>(), new List<string>());

        //vss.Initialize(VssSnapshotContext.All, VssBackupType.Incremental);
        foreach (var vol in Volumes.ListVolumes().Where(v => vss.IsVolumeSupported(v.DeviceID)))
        {
          Log.Information("{0} ({1}) : \"{2}\" - {3}", vol.Name, vol.MountLetter, vol.Label, vol.DeviceID);
        }
        //var ret = vss.QuerySnapshotSet();

        //Dump(ret);
      }

      System.Console.ReadKey();

      AppInit.Shutdown();
    }

    static void Dump<T>(IEnumerable<T> col)
    {
      foreach (T obj in col)
      {
        Dump(obj);
      }
    }

    static void Dump<T>(T obj)
    {
      string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
      System.Console.WriteLine(json + "\n------------------------------------------------------------------");
    }
  }
}
