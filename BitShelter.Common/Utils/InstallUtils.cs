using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Utils
{
  public static class InstallUtils
  {
    private const string InstallScTask = "/Create /F /SC ONLOGON /TN {0} /TR \"{1}\" /RL HIGHEST";
    private const string UninstallScTask = "/Delete /F /TN {0}";
    private const string QueryTask = "/Query /TN {0}";

    public static bool CreateStartupTask(string taskName, string filePath)
    {
      var p = CreateProcess(
        "schtasks",
        String.Format(InstallScTask, taskName, filePath)
      );
      p.Start();
      p.WaitForExit();

      return p.ExitCode == 0;
    }

    public static bool DeleteStartupTask(string taskName)
    {
      var p = CreateProcess(
        "schtasks",
        String.Format(UninstallScTask, taskName)
      );
      p.Start();
      p.WaitForExit();

      return p.ExitCode == 0;
    }

    public static bool TaskExists(string taskName)
    {
      var p = CreateProcess(
        "schtasks",
        String.Format(QueryTask, taskName)
      );
      p.Start();
      p.WaitForExit();

      return p.ExitCode == 0;
    }

    private static Process CreateProcess(string binName, string args)
    {
      Process p = new Process();
      p.StartInfo.FileName = binName;
      p.StartInfo.Arguments = args;
      p.StartInfo.UseShellExecute = false;
      p.StartInfo.CreateNoWindow = true;

      return p;
    }
  }
}
