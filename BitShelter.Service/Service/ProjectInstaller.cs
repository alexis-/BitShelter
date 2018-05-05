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

    protected override void OnAfterInstall(IDictionary savedState)
    {
      base.OnAfterInstall(savedState);
    }

    protected override void OnCommitted(IDictionary savedState)
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

      base.OnCommitted(savedState);
    }

    protected override void OnBeforeUninstall(IDictionary savedState)
    {
      try
      {
        using (var sc = new ServiceController(serviceInstaller.ServiceName))
        {
          if (sc.Status != ServiceControllerStatus.Stopped)
            sc.Stop();
        }
      }
      catch (Exception)
      {
      }

      try
      {
        foreach (var p in Process.GetProcessesByName("BitShelter.Agent"))
        {
          p.Kill();
        }
      }
      catch (Exception)
      {
      }

      base.OnBeforeUninstall(savedState);
    }
  }
}
