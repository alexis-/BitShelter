using Serilog.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models
{
  public class AppConfig
  {
    // 25MB default
    [DefaultValue(26214400)]
    public int LogMaxSize { get; set; }

    [DefaultValue(LogEventLevel.Debug)]
    public LogEventLevel LogMinLevel { get; set; }
  }
}
