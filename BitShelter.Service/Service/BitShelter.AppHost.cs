using BitShelter.Models;
using BitShelter.Service.Config;
using BitShelter.Service.Data;
using BitShelter.Service.Scheduler;
using BitShelter.Service.WCF;
using Serilog;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BitShelter.Service
{
  partial class BitShelter
  {
    private const string ConfigInitErrorMsg = @"A fatal error occured: Configuration could not be loaded.
Please make sure BitShelter execution privileges, {0} folder permissions, and files access are correct.";

    private ServiceHost HostSnapshotService { get; set; }

    public void OnPostInitialize()
    {
      try
      {
        ConfigMgr.Instance.Initialize(this);

        HostSnapshotService = new ServiceHost(typeof(SnapshotService));
        HostSnapshotService.Open();
      }
      catch (Exception ex)
      {
        string err = String.Format(ConfigInitErrorMsg, Const.GetAppDataFolderPath());

        Log.Error(ex, err);
        Log.CloseAndFlush();

        throw new Exception(err, ex);
      }
    }

    public void OnPreInitialize()
    {
      QuartzScheduler.Instance.Start().Wait();
    }

    public void Shutdown()
    {
      HostSnapshotService.Close();

      QuartzScheduler.Instance.Shutdown().Wait();
    }
  }
}
