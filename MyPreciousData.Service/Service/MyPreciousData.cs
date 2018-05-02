using MyPreciousData.Service.Scheduler;
using MyPreciousData.Utils;
using Serilog;
using Serilog.Events;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace MyPreciousData.Service
{
  public partial class MyPreciousData : ServiceBase
  {
    public MyPreciousData()
    {
      InitializeComponent();
    }

    protected void DebugMode()
    {
      Debugger.Launch();
    }

    protected override void OnStart(string[] args)
    {
#if DEBUG
      DebugMode();
#endif

      try
      {
        QuartzScheduler.Instance.Start().Wait();

        AppInit.Initialize(new ServiceAppHost());

        Log.Information("MyPreciousData Service started");
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed to start scheduling service");

        // TODO: Handle error
        throw ex;
      }
    }

    protected override void OnStop()
    {
      try
      {
        AppInit.Shutdown();

        QuartzScheduler.Instance.Shutdown().Wait();

        Log.Information("MyPreciousData Service stopping");
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed to stop scheduling service");

        // TODO: Handle error
        throw ex;
      }
    }
  }
}
