using BitShelter.Agent.Forms;
using BitShelter.Agent.SingleApp;
using BitShelter.Utils;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BitShelter.Agent
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      if (!SingleInstance.Start())
        return;

      var appHost = new DefaultAppHost();

      try
      {
        AppInit.Initialize(appHost);

        Log.Information("BitShelter Agent starting");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var applicationContext = new CustomApplicationContext();
        Application.Run(applicationContext);

        Log.Information("BitShelter Agent stopping");

        AppInit.Shutdown(appHost);
      }
      catch (Exception ex)
      {
        Log.Fatal(ex, "Unrecoverable exception");
        MessageBox.Show(ex.Message, "Program Terminated Unexpectedly",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      SingleInstance.Stop();
    }
  }
}
