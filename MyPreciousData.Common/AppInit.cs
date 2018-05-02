using MyPreciousData.Utils;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData
{
  public static class AppInit
  {
    private const string LoggerInitErrorMsg = @"A fatal error occured: Logger could not be initialized.
Please make sure MyPreciousData execution privileges, {0} folder permissions, and files access are correct.
A log file has been generated: {1}.
Exception is: {2}";
    private const string ConfigInitErrorMsg = @"A fatal error occured: Configuration could not be loaded.
Please make sure MyPreciousData execution privileges, {0} folder permissions, and files access are correct.";

    public static void Initialize(IAppHost appHost)
    {
      appHost.OnPreInitialize();

      try
      {
        Logger.Instance.Initialize();
      }
      catch (Exception ex)
      {
        string tmpFilePath = Path.GetTempFileName();

        using (Stream s = File.OpenWrite(tmpFilePath))
        using (StreamWriter sw = new StreamWriter(s))
          sw.Write(ex.Message);

        throw new Exception(
          String.Format(LoggerInitErrorMsg, ConfigLoader.GetAppDataFolderPath(), tmpFilePath, ex.Message),
          ex
        );
      }

      try
      {
        ConfigMgr.Instance.Initialize(appHost);
      }
      catch (Exception ex)
      {
        string err = String.Format(ConfigInitErrorMsg, ConfigLoader.GetAppDataFolderPath());

        Log.Error(ex, err);

        throw new Exception(err, ex);
      }

      appHost.OnPostInitialize();
    }

    public static void Shutdown()
    {
      ConfigMgr.Instance.Shutdown();
      Logger.Instance.Shutdown();
    }
  }
}
