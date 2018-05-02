using MyPreciousData.Models;
using Quartz;
using Quartz.Impl.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyPreciousData.Data
{
  public static class SnapshotRuleEx
  {
    public static bool HasCalendar(this SnapshotRule rule)
    {
      return (rule.Freq == Freq.Cron && rule.FreqCronDailyLimit) || rule.DailyFreq == DailyFreq.Every;
    }

    public static ICalendar GetCalendar(this SnapshotRule rule)
    {
      DailyCalendar dailyCalendar = null;

      if (rule.Freq == Freq.Cron && rule.FreqCronDailyLimit)
        dailyCalendar = new DailyCalendar(rule.FreqCronDailyStart, rule.FreqCronDailyEnd)
        {
          // ?! Appears to be inverted itself.. What a conundrum
          InvertTimeRange = !rule.FreqCronDailyInvert
        };

      else if (rule.DailyFreq == DailyFreq.Every)
        dailyCalendar = new DailyCalendar(rule.DailyFreqStart, rule.DailyFreqEnd)
        {
          InvertTimeRange = !rule.DailyFreqInvert
        };

      return dailyCalendar;
    }

    public static ITrigger GetTrigger(this SnapshotRule rule)
    {
      TriggerBuilder builder = TriggerBuilder.Create()
        .WithIdentity(rule.Name, "SnapshotJob")
        .WithCronSchedule(rule.GeneratedCron)
        .StartAt(rule.PeriodStart)
        .UsingJobData("RuleId", rule.Id)
        .WithDescription(rule.Name + " - " + rule.ScheduleDescription);

      if (rule.PeriodEndEnabled)
        builder = builder.EndAt(rule.PeriodEnd);

      if (rule.HasCalendar())
        builder = builder.ModifiedByCalendar(rule.Name);

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
