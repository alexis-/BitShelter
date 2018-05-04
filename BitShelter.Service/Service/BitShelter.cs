using BitShelter.Service.Scheduler;
using BitShelter.Utils;
using Serilog;
using Serilog.Events;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace BitShelter.Service
{
  public partial class BitShelter : ServiceBase, IAppHost
  {
    public BitShelter()
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
        AppInit.Initialize(this);

        Log.Information("BitShelter Service started");
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
        AppInit.Shutdown(this);

        Log.Information("BitShelter Service stopping");
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
