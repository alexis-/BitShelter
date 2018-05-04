using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter
{
  public static class Const
  {
    public const string AppName = "BitShelter";

    public const string QuartzGroupSched = "Schedules";
    public const string QuartzGroupBak = "Backups";
    public const string QuartzJobSched = "Schedule";
    public const string QuartzJobBak = "Backup";



    public static string GetAppDataFolderPath()
    {
      return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), AppName);
    }
  }
}
