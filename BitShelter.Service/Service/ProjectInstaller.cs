using BitShelter.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitShelter.Service
{
  [RunInstaller(true)]
  public partial class ProjectInstaller : System.Configuration.Install.Installer
  {
    public ProjectInstaller()
    {
      InitializeComponent();
    }

    protected override void OnBeforeInstall(IDictionary savedState)
    {
      StopAndRemoveService();
      StopAgent();

      base.OnBeforeInstall(savedState);
    }

    protected override void OnCommitted(IDictionary savedState)
    {
      StartAgent();

      base.OnCommitted(savedState);
    }

    protected override void OnBeforeUninstall(IDictionary savedState)
    {
      StopService();
      StopAgent();
      RemoveAgentAutoStartTask();

      base.OnBeforeUninstall(savedState);
    }

    private ServiceController GetService()
    {
      return new ServiceController(serviceInstaller.ServiceName);
    }

    private void StopService()
    {
      try
      {
        var svc = GetService();

        if (svc != null)
        {
          if (svc.Status != ServiceControllerStatus.Stopped)
            svc.Stop();
        }
      }
      catch (Exception)
      {
      }
    }

    private void StopAndRemoveService()
    {
      try
      {
        var svc = GetService();

        if (svc != null)
        {
          if (svc.Status != ServiceControllerStatus.Stopped)
            svc.Stop();

          var svcInstaller = new ServiceInstaller();
          svcInstaller.ServiceName = serviceInstaller.ServiceName;
          svcInstaller.Uninstall(null);
        }
      }
      catch (Exception)
      {
      }
    }

    private void StartAgent()
    {
      try
      {
        using (var sc = new ServiceController(serviceInstaller.ServiceName))
        {
          sc.Start();
        }
      }
      catch (Exception)
      {
      }
    }

    private void StopAgent()
    {
      var runningAgents = Process.GetProcessesByName("BitShelter.Agent"); // There should be only one

      foreach (var p in runningAgents)
      {
        try
        {
          p.Kill();
        }
        catch (Exception)
        {
        }
      }
    }

    private void RemoveAgentAutoStartTask()
    {
      try
      {
        if (InstallUtils.TaskExists(Const.AppName))
          InstallUtils.DeleteStartupTask(Const.AppName);
      }
      catch (Exception ex)
      {
      }
    }
  }
}
