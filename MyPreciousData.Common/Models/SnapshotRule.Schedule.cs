using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Models
{
  partial class SnapshotRule
  {
    // Daily frequency
    public DailyFreq DailyFreq { get; set; }
    public DateTime DailyFreqOnce { get; set; }
    public int DailyFreqEvery { get; set; }
    public DateTime DailyFreqStart { get; set; }
    public DateTime DailyFreqEnd { get; set; }
    public bool DailyFreqInvert { get; set; }

    // Frequency
    public Freq Freq { get; set; }
    public int FreqDailyEvery { get; set; }
    public FreqWeekly FreqWeekly { get; set; }
    public int FreqWeeklyEvery { get; set; }
    public HashSet<int> FreqWeeklyDays { get; set; }
    public HashSet<int> FreqMonthlyMonths { get; set; }
    public HashSet<int> FreqMonthlyDays { get; set; }
    public string FreqCron { get; set; }
    public bool FreqCronDailyLimit { get; set; }
    public DateTime FreqCronDailyStart { get; set; }
    public DateTime FreqCronDailyEnd { get; set; }
    public bool FreqCronDailyInvert { get; set; }

    // Period
    public DateTime PeriodStart { get; set; }
    public bool PeriodEndEnabled { get; set; }
    public DateTime PeriodEnd { get; set; }

    // Human readable schedule
    public string ScheduleDescription { get; set; }

    // Generated schedule
    public string GeneratedCron { get; set; }
  }
}
