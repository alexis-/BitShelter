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
    public DateTime DailyFreqStart { get; set; }
    [DataMember]
    public DateTime DailyFreqEnd { get; set; }
    [DataMember]
    public bool DailyFreqInvert { get; set; }

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
    public bool FreqCronDailyLimit { get; set; }
    [DataMember]
    public DateTime FreqCronDailyStart { get; set; }
    [DataMember]
    public DateTime FreqCronDailyEnd { get; set; }
    [DataMember]
    public bool FreqCronDailyInvert { get; set; }

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
