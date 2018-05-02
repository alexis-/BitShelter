using MyPreciousData.Models;
using Quartz;
using Quartz.Impl.Calendar;

namespace MyPreciousData.Service.Helpers
{
  static class ScheduleUtils
  {

    public static void GenerateQuartzSchedule(SnapshotRule sched, out ITrigger trigger, out ICalendar calendar)
    {
      trigger = TriggerBuilder.Create()
        .WithIdentity(sched.Name, Const.QuartzGroupSched)
        .WithCronSchedule(sched.GeneratedCron)
        .ForJob(Const.QuartzJobSched, Const.QuartzGroupSched)
        .Build();

      calendar = sched.DailyFreq == DailyFreq.Every
        ? new DailyCalendar(sched.DailyFreqStart, sched.DailyFreqEnd)
        : null;
    }
  }
}
