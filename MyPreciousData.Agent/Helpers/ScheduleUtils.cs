using CronExpressionDescriptor;
using MyPreciousData.Models;
using System;
using System.Linq;

namespace MyPreciousData.Agent.Helpers
{
  static class ScheduleUtils
  {
    public static string GetHumanizedSchedule(SnapshotRule sched)
    {
      string expr = ExpressionDescriptor.GetDescription(sched.GeneratedCron);

      if (sched.Freq != Freq.Cron && sched.DailyFreq == DailyFreq.Every)
        expr += String.Format(", Between {0} and {1}",
          sched.DailyFreqInvert
            ? sched.DailyFreqEnd.ToShortTimeString()
            : sched.DailyFreqStart.ToShortTimeString(),
          sched.DailyFreqInvert
            ? sched.DailyFreqStart.ToShortTimeString()
            : sched.DailyFreqEnd.ToShortTimeString()
        );

      else if (sched.Freq == Freq.Cron && sched.FreqCronDailyLimit)
        expr += String.Format(", Between {0} and {1}",
          sched.FreqCronDailyInvert
            ? sched.FreqCronDailyEnd.ToShortTimeString()
            : sched.FreqCronDailyStart.ToShortTimeString(),
          sched.FreqCronDailyInvert
            ? sched.FreqCronDailyStart.ToShortTimeString()
            : sched.FreqCronDailyEnd.ToShortTimeString()
        );

      return expr;
    }

    public static string GenerateCron(SnapshotRule sched)
    {
      if (sched.Freq == Freq.Cron)
        return sched.FreqCron;

      string cron = "0 ";

      //
      // Minute Hour
      switch (sched.DailyFreq)
      {
        case DailyFreq.Once:
          cron += String.Format("{0} {1} ", sched.DailyFreqOnce.Minute, sched.DailyFreqOnce.Hour);
          break;

        case DailyFreq.Every:
          // Minutes
          if (sched.DailyFreqEvery % 60 != 0)
            cron += String.Format("*/{0} * ", sched.DailyFreqEvery);

          // Hours
          else
            cron += String.Format("0 */{0} ", sched.DailyFreqEvery / 60);

          break;

        default:
          //MessageBox.Show("Invalid daily frequency selection.");
          return string.Empty;
      }


      //
      // DayOfMonth Month DayOfWeek
      switch (sched.Freq)
      {
        case Freq.Daily:
          cron += String.Format("{0} * ?", (sched.FreqDailyEvery == 1 ? "*" : "*/" + sched.FreqDailyEvery));
          break;

        case Freq.Weekly:
          switch (sched.FreqWeekly)
          {
            case FreqWeekly.Weekly:
              cron += String.Format("{0} * ?", "*/" + sched.FreqWeeklyEvery * 7);
              break;

            case FreqWeekly.OnDays:
              cron += String.Format("? * {0}", String.Join(",", sched.FreqWeeklyDays));
              break;

            default:
              //MessageBox.Show("Invalid weekly schedule selection.");
              return string.Empty;
          }
          break;

        case Freq.Monthly:
          cron += String.Format("{0} {1} ?",
            String.Join(",", sched.FreqMonthlyDays.Select(i => (i + 1).ToString())),
            String.Join(",", sched.FreqMonthlyMonths.Select(i => (i + 1).ToString()))
          );
          break;

        default:
          //MessageBox.Show("Invalid frequency selection.");
          return string.Empty;
      }

      return cron;
    }
  }
}
