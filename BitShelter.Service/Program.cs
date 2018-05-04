using System.Diagnostics;
using System.ServiceProcess;

namespace BitShelter.Service
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static void Main()
    {
      DebugMode();

      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
        new BitShelter()
      };

      ServiceBase.Run(ServicesToRun);
    }

    // https://stackoverflow.com/questions/125964/easier-way-to-debug-a-windows-service?noredirect=1&lq=1
    [Conditional("DEBUG_SERVICE")]
    private static void DebugMode()
    {
      Debugger.Launch();
    }
  }
}
