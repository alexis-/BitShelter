using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Utils
{
  public static class QuartzUtils
  {
    // Adapted from https://github.com/quartznet/quartznet/blob/master/src/Quartz/TriggerUtils.cs
    public static int ComputeFireTimeCountBetween(IOperableTrigger trigg, ICalendar cal, DateTimeOffset from, DateTimeOffset to)
    {
      int count = 0;
      IOperableTrigger t = (IOperableTrigger)trigg.Clone();

      if (t.GetNextFireTimeUtc() == null || !t.GetNextFireTimeUtc().HasValue)
      {
        t.StartTimeUtc = from;
        t.EndTimeUtc = to;
        t.ComputeFirstFireTimeUtc(cal);
      }

      // TODO: this method could be more efficient by using logic specific
      //        to the type of trigger ...
      while (true)
      {
        DateTimeOffset? d = t.GetNextFireTimeUtc();
        if (d.HasValue)
        {
          if (d.Value < from)
          {
            t.Triggered(cal);
            continue;
          }
          if (d.Value > to)
          {
            break;
          }
          count++;
          t.Triggered(cal);
        }
        else
        {
          break;
        }
      }
      return count;
    }
  }
}
