using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Exceptions;
using System;
using System.IO;

namespace BitShelter.Utils
{
  public class Logger
  {
    protected const string OutputFormat = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}";
    protected LoggingLevelSwitch LevelSwitch { get; set; }


    private static Logger instance;
    public static Logger Instance => instance ?? (instance = new Logger());


    protected Logger() {}

    public void Initialize()
    {
      LevelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug); // ConfigMgr.AppConfig.LogMinLevel);

      Log.Logger = new LoggerConfiguration()
        .MinimumLevel.ControlledBy(LevelSwitch)
        .Enrich.WithExceptionDetails()
        .Enrich.WithDemystifiedStackTraces()
        .WriteTo.Debug(outputTemplate: OutputFormat)
        .WriteTo.EventLog(
          Const.AppName,
          restrictedToMinimumLevel: LogEventLevel.Information,
          manageEventSource: true)
        .WriteTo.Async(a =>
          a.RollingFile(
            GetLogFilePath(),
            fileSizeLimitBytes: 5242880, // Math.Min(ConfigMgr.AppConfig.LogMaxSize, 26214400),
            retainedFileCountLimit: 7,
            shared: true,
            outputTemplate: OutputFormat
          ))
        .CreateLogger();
    }

    public static string GetLogFilePath()
    {
      string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

      return Path.Combine(appData, Const.AppName, "log-{Date}.txt");
    }

    public void SetMinimumLevel(LogEventLevel level)
    {
      LevelSwitch.MinimumLevel = level;
    }

    public void Shutdown()
    {
      Log.CloseAndFlush();
    }
  }
}
