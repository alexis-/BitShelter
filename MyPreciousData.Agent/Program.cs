using MyPreciousData.Agent.Forms;
using MyPreciousData.Agent.SingleApp;
using MyPreciousData.Utils;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPreciousData.Agent
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if (!SingleInstance.Start())
        return;

      try
      {
        AppInit.Initialize(new DefaultAppHost());

        Log.Information("MyPreciousData Agent starting");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var applicationContext = new CustomApplicationContext();
        Application.Run(applicationContext);

        Log.Information("MyPreciousData Agent stopping");

        AppInit.Shutdown();
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
