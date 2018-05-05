using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Models
{
  partial class SnapshotRule
  {
    // Daily frequency
    [DataMember]
    public DailyFreq DailyFreq { get; set; }
    [DataMember]
    public DateTime DailyFreqOnce { get; set; }
    [DataMember]
    public int DailyFreqEvery { get; set; }
    [DataMember]
    public bool DailyFreqEveryExcluding { get; set; }
    [DataMember]
    public DateTime DailyFreqEveryExcludingFrom { get; set; }
    [DataMember]
    public DateTime DailyFreqEveryExcludingTo { get; set; }

    // Frequency
    [DataMember]
    public Freq Freq { get; set; }
    [DataMember]
    public int FreqDailyEvery { get; set; }
    [DataMember]
    public FreqWeekly FreqWeekly { get; set; }
    [DataMember]
    public int FreqWeeklyEvery { get; set; }
    [DataMember]
    public HashSet<int> FreqWeeklyDays { get; set; }
    [DataMember]
    public HashSet<int> FreqMonthlyMonths { get; set; }
    [DataMember]
    public HashSet<int> FreqMonthlyDays { get; set; }
    [DataMember]
    public string FreqCron { get; set; }
    [DataMember]
    public bool FreqCronDailyExcluding { get; set; }
    [DataMember]
    public DateTime FreqCronDailyExcludingFrom { get; set; }
    [DataMember]
    public DateTime FreqCronDailyExcludingTo { get; set; }

    // Period
    [DataMember]
    public DateTime PeriodStart { get; set; }
    [DataMember]
    public bool PeriodEndEnabled { get; set; }
    [DataMember]
    public DateTime PeriodEnd { get; set; }

    // Human readable schedule
    [DataMember]
    public string ScheduleDescription { get; set; }

    // Generated schedule
    [DataMember]
    public string GeneratedCron { get; set; }
  }
}
