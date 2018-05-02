using Alphaleonis.Win32.Vss;
using MyPreciousData.Data;
using MyPreciousData.Utils;
using MyPreciousData.VSS;
using Quartz;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Service.Jobs
{
  public class PruneJob : IJob
  {
    public Task Execute(IJobExecutionContext context)
    {
      VssClient vss = null;

      try
      {
        vss = new VssClient(new VssHost());
        vss.Initialize(VssSnapshotContext.All, VssBackupType.Incremental);

        PruningMgr.Instance.DoPruning(vss);
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed PruneJob");

        throw new JobExecutionException(ex, false);
      }
      finally
      {
        if (vss != null)
        {
          vss.Dispose();
          vss = null;
        }
      }

      return TaskConst.Completed;
    }
  }
}
