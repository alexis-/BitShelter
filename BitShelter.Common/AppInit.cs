using BitShelter.Utils;
using System;
using System.IO;

namespace BitShelter
{
  public static class AppInit
  {
    private const string LoggerInitErrorMsg = @"A fatal error occured: Logger could not be initialized.
Please make sure BitShelter execution privileges, {0} and other files access are correct.
A log file has been generated: {1}.
Exception is: {2}";

    public static void Initialize(IAppHost appHost)
    {
      appHost.OnPreInitialize();

      try
      {
        string appDataFolder = Const.GetAppDataFolderPath();

        Directory.CreateDirectory(appDataFolder);

        Logger.Instance.Initialize();
      }
      catch (Exception ex)
      {
        string tmpFilePath = Path.GetTempFileName();

        using (Stream s = File.OpenWrite(tmpFilePath))
        using (StreamWriter sw = new StreamWriter(s))
          sw.Write(ex.Message);

        throw new Exception(
          String.Format(LoggerInitErrorMsg, Logger.GetLogFilePath(), tmpFilePath, ex.Message),
          ex
        );
      }

      appHost.OnPostInitialize();
    }

    public static void Shutdown(IAppHost appHost)
    {
      Logger.Instance.Shutdown();

      appHost.Shutdown();
    }
  }
}
