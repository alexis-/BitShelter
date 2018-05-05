using BitShelter.Models;
using Quartz;
using Quartz.Impl.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitShelter.Data
{
  public static class SnapshotRuleEx
  {
    public static bool IsExcludingDayRange(this SnapshotRule rule)
    {
      return (rule.Freq == Freq.Cron && rule.FreqCronDailyExcluding) || (rule.DailyFreq == DailyFreq.Every && rule.DailyFreqEveryExcluding);
    }

    public static void GetExcludingDayRange(
      this SnapshotRule rule,
      out DateTime from,
      out DateTime to)
    {
      if (rule.Freq == Freq.Cron && rule.FreqCronDailyExcluding)
      {
        from = rule.FreqCronDailyExcludingFrom;
        to = rule.FreqCronDailyExcludingTo;
      }

      else if (rule.DailyFreq == DailyFreq.Every && rule.DailyFreqEveryExcluding)
      {
        from = rule.DailyFreqEveryExcludingFrom;
        to = rule.DailyFreqEveryExcludingTo;
      }

      else
        throw new InvalidOperationException("GetExcludingDayRange called without excluding one");
    }

    public static bool HasCalendar(this SnapshotRule rule)
    {
      return rule.IsExcludingDayRange();
    }

    public static ICalendar GetCalendar(this SnapshotRule rule)
    {
      if (rule.HasCalendar() == false)
        return null;

      // Modify here to handle several calendar if necessary in the future
      // Beware of calling GetExcludingDayRange if no exclusion range enabled
      rule.GetExcludingDayRange(out DateTime from, out DateTime to);
      return new DailyCalendar(from, to);
    }

    public static string GetCalendarName(this SnapshotRule rule)
    {
      return rule.ToString();
    }

    public static ITrigger GetTrigger(this SnapshotRule rule)
    {
      TriggerBuilder builder = TriggerBuilder.Create()
        .WithIdentity(rule.ToString(), "SnapshotJob")
        .WithCronSchedule(rule.GeneratedCron)
        .StartAt(rule.PeriodStart)
        .UsingJobData("RuleId", rule.Id)
        .WithDescription(rule.ToString());

      if (rule.PeriodEndEnabled)
        builder = builder.EndAt(rule.PeriodEnd);

      if (rule.HasCalendar())
        builder = builder.ModifiedByCalendar(rule.GetCalendarName());

      return builder.Build();
    }

    public static long GetLifeTimeSeconds(this SnapshotRule rule)
    {
      return rule.LifeTimeValue * (long)rule.LifeTimeUnit;
    }

    public static DateTimeOffset? GetNextFireTime(this SnapshotRule rule, DateTimeOffset from)
    {
      ICalendar calendar = rule.GetCalendar();
      CronExpression cron = new CronExpression(rule.GeneratedCron);

      DateTimeOffset? it = from;

      do
      {
        it = cron.GetNextValidTimeAfter(it.Value);

        if (it.HasValue)
        {
          if (calendar != null && !calendar.IsTimeIncluded(it.Value))
            continue;

          return it.Value;
        }
        else
          return null;
      } while (true);
    }

    public static int GetFireCountBetween(this SnapshotRule rule, DateTimeOffset from, DateTimeOffset to, CancellationToken cancel)
    {
      int count = 0;
      ICalendar calendar = rule.GetCalendar();
      CronExpression cron = new CronExpression(rule.GeneratedCron);
      
      DateTimeOffset? it = from;

      do
      {
        it = cron.GetNextValidTimeAfter(it.Value);

        if (it.HasValue)
        {
          if (calendar != null && !calendar.IsTimeIncluded(it.Value))
            continue;

          else if (it.Value > to)
            break;

          count++;
        }
        else
          break;
      } while (cancel == null || cancel.IsCancellationRequested == false);

      return count;
    }
  }
}
