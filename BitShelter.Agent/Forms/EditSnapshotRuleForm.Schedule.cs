using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BitShelter.Agent.Helpers;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;

namespace BitShelter.Agent.Forms
{
  partial class EditSnapshotRuleForm
  {
    //
    // Properties

    public SnapshotRule SnapshotRule { get; private set; }

    private CheckBoxAdv[] DayCheckboxes { get; set; }



    //
    // Initialization

    private void InitBaseSchedule()
    {
      DayCheckboxes = new[] { cbFreqWeeklySunday, cbFreqWeeklyMonday, cbFreqWeeklyTuesday, cbFreqWeeklyWednesday, cbFreqWeeklyThursday, cbFreqWeeklyFriday, cbFreqWeeklySaturday };

      ChangeDailyFreq(DailyFreq.Once);
      ChangeFreq(Freq.Daily);
      ChangeFreqWeekly(FreqWeekly.Weekly);

      cbDailyFreqEveryExcluding.Checked = false;
      ChangeDailyFreqEveryExcludingEnabled(false);

      llbFreqCronHelp.Links.Add(0, 0, "https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontriggers.html");
      llbFreqCronGen.Links.Add(0, 0, "https://www.freeformatter.com/cron-expression-generator-quartz.html");

      dtpPeriodStart.Value = DateTime.Today;
      dtpPeriodEnd.Value = DateTime.Today.AddMonths(1);

      cbDailyFreqEvery.SelectedIndex = 1;

      for (int i = 0; i < cblFreqMonthlyMonths.Items.Count; i++)
        cblFreqMonthlyMonths.SetItemChecked(i, true);

      cblFreqMonthlyDays.SetItemChecked(0, true);

      cbFreqCronExcluding.Checked = false;
      ChangeCronExcludingEnabled(false);
    }

    private void InitEditSchedule(SnapshotRule sched)
    {
      // Daily frequency
      SelectDailyFreq(sched.DailyFreq);
      dtpDailyFreqOnce.Value = sched.DailyFreqOnce;

      if (sched.DailyFreqEvery % 60 == 0)
      {
        nbDailyFreqEvery.Value = sched.DailyFreqEvery / 60;
        cbDailyFreqEvery.SelectedIndex = 1;
      }
      else
      {
        nbDailyFreqEvery.Value = sched.DailyFreqEvery;
        cbDailyFreqEvery.SelectedIndex = 0;
      }

      cbDailyFreqEveryExcluding.Checked = sched.DailyFreqEveryExcluding;
      dtpDailyFreqEveryExcludingFrom.Value = sched.DailyFreqEveryExcludingFrom;
      dtpDailyFreqEveryExcludingTo.Value = sched.DailyFreqEveryExcludingTo;


      // Frequency
      SelectFreq(sched.Freq);

      nbFreqDaily.Value = sched.FreqDailyEvery;

      SelectFreqWeekly(sched.FreqWeekly);
      nbFreqWeekly.Value = sched.FreqWeeklyEvery;

      for (int i = 0; i < DayCheckboxes.Length; i++)
        DayCheckboxes[i].Checked = sched.FreqWeeklyDays.Contains(i);

      for (int i = 0; i < cblFreqMonthlyMonths.Items.Count; i++)
        cblFreqMonthlyMonths.SetItemChecked(i, sched.FreqMonthlyMonths.Contains(i));

      for (int i = 0; i < cblFreqMonthlyDays.Items.Count; i++)
        cblFreqMonthlyDays.SetItemChecked(i, sched.FreqMonthlyDays.Contains(i));

      tbFreqCron.Text = sched.FreqCron;
      cbFreqCronExcluding.Checked = sched.FreqCronDailyExcluding;
      dtpFreqCronExcludingFrom.Value = sched.FreqCronDailyExcludingFrom;
      dtpFreqCronExcludingTo.Value = sched.FreqCronDailyExcludingTo;


      // Period
      dtpPeriodStart.Value = sched.PeriodStart;

      SelectPeriodEnd(sched.PeriodEndEnabled == false);
      dtpPeriodEnd.Value = sched.PeriodEnd;
    }



    //
    // Form


    //
    // General

    private void onChange_RefreshUI(object sender, EventArgs e)
    {
      RefreshUI();
    }


    //
    // Daily frequency

    private void rbDailyFreqOnce_CheckedChanged(object sender, EventArgs e)
    {
      ChangeDailyFreq(DailyFreq.Once);
    }

    private void rbDailyFreqEvery_CheckedChanged(object sender, EventArgs e)
    {
      ChangeDailyFreq(DailyFreq.Every);
    }

    private void cbDailyFreqEveryExcluding_CheckedChanged(object sender, EventArgs e)
    {
      ChangeDailyFreqEveryExcludingEnabled(cbDailyFreqEveryExcluding.Checked);
    }

    private void SelectDailyFreq(DailyFreq freq)
    {
      switch (freq)
      {
        case DailyFreq.Once:
          rbDailyFreqOnce.Checked = true;
          break;

        case DailyFreq.Every:
          rbDailyFreqEvery.Checked = true;
          break;
      }
    }

    private void ChangeDailyFreq(DailyFreq freq)
    {
      bool once = freq == DailyFreq.Once;

      dtpDailyFreqOnce.Enabled = once;

      nbDailyFreqEvery.Enabled = !once;
      cbDailyFreqEvery.Enabled = !once;
      cbDailyFreqEveryExcluding.Enabled = !once;

      RefreshUI();
    }

    private void ChangeDailyFreqEveryExcludingEnabled(bool enabled)
    {
      dtpDailyFreqEveryExcludingFrom.Enabled = dtpDailyFreqEveryExcludingTo.Enabled = enabled;
      
      RefreshUI();
    }



    //
    // Frequency

    private void rbFreqDaily_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreq(Freq.Daily);
    }

    private void rbFreqWeekly_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreq(Freq.Weekly);
    }

    private void rbFreqMonthly_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreq(Freq.Monthly);
    }

    private void rbFreqCron_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreq(Freq.Cron);
    }

    private void rbFreqWeeklyEvery_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreqWeekly(FreqWeekly.Weekly);
    }

    private void rbFreqWeeklyOn_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFreqWeekly(FreqWeekly.OnDays);
    }

    private void cbFreqWeeklySunday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklyMonday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklyTuesday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklyWednesday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklyThursday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklyFriday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqWeeklySaturday_CheckedChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cblFreqMonthlyMonths_ItemCheckStateChanged(object sender, EWSoftware.ListControls.ItemCheckStateEventArgs e)
    {
      RefreshUI();
    }

    private void cblFreqMonthlyDays_ItemCheckStateChanged(object sender, EWSoftware.ListControls.ItemCheckStateEventArgs e)
    {
      RefreshUI();
    }

    private void tbFreqCron_TextChanged(object sender, EventArgs e)
    {
      RefreshUI();
    }

    private void cbFreqCronExcluding_CheckedChanged(object sender, EventArgs e)
    {
      ChangeCronExcludingEnabled(cbFreqCronExcluding.Checked);
    }

    private void ChangeCronExcludingEnabled(bool enabled)
    {
      dtpFreqCronExcludingFrom.Enabled = dtpFreqCronExcludingTo.Enabled = enabled;

      RefreshUI();
    }

    private void SelectFreqWeekly(FreqWeekly freq)
    {
      switch (freq)
      {
        case FreqWeekly.OnDays:
          rbFreqWeeklyOn.Checked = true;
          break;

        case FreqWeekly.Weekly:
          rbFreqWeeklyEvery.Checked = true;
          break;
      }
    }

      private void ChangeFreqWeekly(FreqWeekly freq)
    {
      nbFreqWeekly.Enabled = freq == FreqWeekly.Weekly;

      foreach (Control c in DayCheckboxes)
        c.Enabled = freq == FreqWeekly.OnDays;

      RefreshUI();
    }

    private void SelectFreq(Freq freq)
    {
      switch (freq)
      {
        case Freq.Daily:
          rbFreqDaily.Checked = true;
          break;

        case Freq.Weekly:
          rbFreqWeekly.Checked = true;
          break;

        case Freq.Monthly:
          rbFreqMonthly.Checked = true;
          break;

        case Freq.Cron:
          rbFreqCron.Checked = true;
          break;
      }
    }

    private void ChangeFreq(Freq freq)
    {
      bool daily = freq == Freq.Daily;
      bool weekly = freq == Freq.Weekly;
      bool monthly = freq == Freq.Monthly;
      bool cron = freq == Freq.Cron;

      gbDailyFreq.Enabled = !cron;

      plFreqDaily.Enabled = plFreqDaily.Visible = daily;
      plFreqWeekly.Enabled = plFreqWeekly.Visible = weekly;
      plFreqMonthly.Enabled = plFreqMonthly.Visible = monthly;
      plFreqCron.Enabled = plFreqCron.Visible = cron;

      RefreshUI();
    }



    //
    // Period

    private void rbPeriodEndNever_CheckedChanged(object sender, EventArgs e)
    {
      ChangePeriodEnd(true);
    }

    private void rbPeriodEndDate_CheckedChanged(object sender, EventArgs e)
    {
      ChangePeriodEnd(false);
    }

    private void SelectPeriodEnd(bool never)
    {
      rbPeriodEndDate.Checked = !never;
    }

      private void ChangePeriodEnd(bool never)
    {
      dtpPeriodEnd.Enabled = !never;

      RefreshUI();
    }



    //
    // Misc

    private void FillSchedule(SnapshotRule sched)
    {
      // Daily Freq
      sched.DailyFreq = GetDailyFreq();
      sched.DailyFreqOnce = dtpDailyFreqOnce.Value;
      sched.DailyFreqEvery = (int)nbDailyFreqEvery.Value * (cbDailyFreqEvery.SelectedIndex == 0 ? 1 : 60);
      sched.DailyFreqEveryExcluding = cbDailyFreqEveryExcluding.Checked;
      sched.DailyFreqEveryExcludingFrom = dtpDailyFreqEveryExcludingFrom.Value;
      sched.DailyFreqEveryExcludingTo = dtpDailyFreqEveryExcludingTo.Value;
        
      // Frequency
      sched.Freq = GetFreq();
      sched.FreqDailyEvery = (int)nbFreqDaily.Value;
      sched.FreqWeekly = GetFreqWeekly();
      sched.FreqWeeklyEvery = (int)nbFreqWeekly.Value;
      sched.FreqWeeklyDays = GetWeeklyDays();
      sched.FreqMonthlyMonths = GetMonthlyMonths();
      sched.FreqMonthlyDays = GetMonthlyDays();
      sched.FreqCron = tbFreqCron.Text;
      sched.FreqCronDailyExcluding = cbFreqCronExcluding.Checked;
      sched.FreqCronDailyExcludingFrom = dtpFreqCronExcludingFrom.Value;
      sched.FreqCronDailyExcludingTo = dtpFreqCronExcludingTo.Value;

      // Period
      sched.PeriodStart = dtpPeriodStart.Value;
      sched.PeriodEndEnabled = rbPeriodEndDate.Checked;
      sched.PeriodEnd = dtpPeriodEnd.Value;

      sched.GeneratedCron = ScheduleUtils.GenerateCron(sched);
      sched.ScheduleDescription = ScheduleUtils.GetHumanizedSchedule(sched);
    }



    //
    // Getter

    private HashSet<int> GetWeeklyDays()
    {
      return new HashSet<int>(
        DayCheckboxes.Select((cb, idx) => cb.Checked ? idx : -1)
                     .Where(idx => idx >= 0)
      );
    }

    private HashSet<int> GetMonthlyMonths()
    {
      return new HashSet<int>(
        cblFreqMonthlyMonths.CheckedIndices
      );
    }

    private HashSet<int> GetMonthlyDays()
    {
      return new HashSet<int>(
        cblFreqMonthlyDays.CheckedIndices
      );
    }

    private DailyFreq GetDailyFreq()
    {
      if (rbDailyFreqOnce.Checked)
        return DailyFreq.Once;

      else if (rbDailyFreqEvery.Checked)
        return DailyFreq.Every;

      else
        return DailyFreq.Unknown;
    }

    private Freq GetFreq()
    {
      if (rbFreqDaily.Checked)
        return Freq.Daily;

      else if (rbFreqWeekly.Checked)
        return Freq.Weekly;

      else if (rbFreqMonthly.Checked)
        return Freq.Monthly;

      else if (rbFreqCron.Checked)
        return Freq.Cron;

      else
        return Freq.Unknown;
    }

    private FreqWeekly GetFreqWeekly()
    {
      if (rbFreqWeeklyEvery.Checked)
        return FreqWeekly.Weekly;

      else if (rbFreqWeeklyOn.Checked)
        return FreqWeekly.OnDays;

      else
        return FreqWeekly.Unknown;
    }



    //
    // Validation

    private bool ValidateSchedule()
    {
      bool valid = true;

      valid = ValidateDailyTimeRange() && valid;
      valid = ValidateFreqWeekly() && valid;
      valid = ValidateFreqMonthly() && valid;
      valid = ValidateFreqCron() && valid;
      valid = ValidatePeriod() && valid;
      valid = GetFreq() != Freq.Unknown && valid;
      valid = GetDailyFreq() != DailyFreq.Unknown && valid;

      return valid;
    }

    private bool ValidateDailyTimeRange()
    {
      if (rbDailyFreqOnce.Checked)
        return true;

      if (dtpDailyFreqEveryExcludingTo.Value.TimeOfDay <= dtpDailyFreqEveryExcludingFrom.Value.TimeOfDay)
      {
        // Display error
        SetStyleInvalid(lblDailyFreqEveryStartAt, lblDailyFreqEveryEndAt);

        return false;
      }

      else
      {
        // Restore font if necessary
        SetStyleValid(lblDailyFreqEveryStartAt, lblDailyFreqEveryEndAt);

        return true;
      }
    }

    private bool ValidateFreqWeekly()
    {
      if (rbFreqWeekly.Checked == false || rbFreqWeeklyOn.Checked == false)
        return true;

      bool valid = DayCheckboxes.Any(cb => cb.Checked);

      if (!valid)
        SetStyleInvalid(DayCheckboxes);

      else
        SetStyleValid(DayCheckboxes);

      return valid;
    }

    private bool ValidateFreqMonthly()
    {
      if (rbFreqMonthly.Checked == false)
        return true;

      bool valid = true;

      if (cblFreqMonthlyMonths.CheckedIndices.Count == 0)
      {
        // Display error
        SetStyleInvalid(lblFreqMonthlyMonths);

        valid = false;
      }
      else
        // Restore font if necessary
        SetStyleValid(lblFreqMonthlyMonths);

      if (cblFreqMonthlyDays.CheckedIndices.Count == 0)
      {
        // Display error
        SetStyleInvalid(lblFreqMonthlyDays);

        valid = false;
      }
      else
        // Restore font if necessary
        SetStyleValid(lblFreqMonthlyDays);

      return valid;
    }

    private bool ValidateFreqCron()
    {
      if (rbFreqCron.Checked == false)
        return true;

      bool valid = true;

      if (Quartz.CronExpression.IsValidExpression(tbFreqCron.Text) == false)
      {
        // Display error
        SetStyleInvalid(lblFreqCron);

        valid = false;
      }
      else
        // Restore font if necessary
        SetStyleValid(lblFreqCron);

      if (!cbFreqCronExcluding.Checked && dtpFreqCronExcludingTo.Value <= dtpFreqCronExcludingFrom.Value)
      {
        // Display error
        SetStyleInvalid(lblFreqCronStart, lblFreqCronEnd);

        valid = false;
      }
      else
        // Restore font if necessary
        SetStyleValid(lblFreqCronStart, lblFreqCronEnd);

      return valid;
    }

    private bool ValidatePeriod()
    {
      if (!rbPeriodEndDate.Checked && dtpPeriodEnd.Value <= dtpPeriodStart.Value)
      {
        // Display error
        SetStyleInvalid(lblPeriodStart, lblPeriodEnd);

        return false;
      }

      else
      {
        // Restore font if necessary
        SetStyleValid(lblPeriodStart, lblPeriodEnd);

        return true;
      }
    }
  }
}
