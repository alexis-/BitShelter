using Alphaleonis.Win32.Vss;
using BitShelter.Models;
using BitShelter.Service.Data;
using BitShelter.Service.Scheduler;
using BitShelter.Utils;
using BitShelter.VSS;
using Quartz;
using Serilog;
using System;
using System.Threading.Tasks;

namespace BitShelter.Service.Jobs
{
  // https://www.quartz-scheduler.net/documentation/best-practices.html
  [DisallowConcurrentExecution]
  public class SnapshotJob : IJob
  {
    public long RuleId { get; set; }
    public int RetryCount { get; set; }

    public Task Execute(IJobExecutionContext context)
    {
      // Quartz.NET seem to fire each Trigger once after scheduling them, regardless of their real fire time.
      // This is an attempt to fix that issue.
      if (context.PreviousFireTimeUtc == null)
        return TaskConst.Completed;

      VssClient vss = null;
      int maxRetryCount = -1;

      try
      {
        SnapshotRule rule = RuleMgr.Instance.GetRule(RuleId);

        if (rule == null)
        {
          Log.Error("Failed to retrieve SnapshotRule {RuleId}", RuleId);

          throw new InvalidOperationException(String.Format("Failed to retrieve SnapshotRule {0}", RuleId));
        }

        Log.Debug("Executing SnapshotJob for {rule.Name}", rule.Name);

        if (rule.Enabled == false) // Shouldn't happen expect in rare cases
          return TaskConst.Completed;

        vss = new VssClient(new VssHost());
        vss.Initialize((VssSnapshotContext)rule.VssContext, (VssBackupType)rule.VssBackupType);

        var snapshotIds = vss.CreateSnapshot(rule.Volumes, null, rule.VssExcludeWriters, rule.VssIncludeWriters);

        PruningMgr.Instance.CreateNewInstances(rule.Id, snapshotIds);

        // TODO: Implement backups
        if (false && rule.BackupEnabled && rule.BackupRules != null && rule.BackupRules.Count > 0)
          ScheduleBackup(context.Scheduler);

        Log.Debug("Completed SnapshotJob for {RuleId}", RuleId);
      }
      catch (Exception ex)
      {
        Log.Error(ex, "Failed SnapshotJob for {RuleId}", RuleId);

        Retry(ex, context.Scheduler, context.JobDetail, maxRetryCount);

        return TaskConst.Canceled;
      }
      finally
      {
        if (vss != null)
        {
          vss.Dispose();
          vss = null;
        }
      }

      return TaskConst.Completed;
    }

    protected void ScheduleBackup(IScheduler scheduler)
    {
      Log.Debug("Scheduling BackupJob for {RuleId}", RuleId);

      ITrigger backupTrigger = TriggerBuilder.Create()
        .ForJob(VssScheduler.BackupJob)
        .StartAt(DateTime.Now.AddSeconds(5))
        .UsingJobData("RuleId", RuleId)
        .Build();

      scheduler.ScheduleJob(backupTrigger).Wait();
    }

    protected void Retry(Exception ex, IScheduler scheduler, IJobDetail jobDetail, int maxRetryCount)
    {
      if (RetryCount < maxRetryCount)
      {
        Log.Information("Retrying SnapshotJob for {RuleId} in 1 minute (attempt {RetryCount}/{MaxRetryCount})", RuleId, RetryCount, maxRetryCount);

        ITrigger trigger = TriggerBuilder.Create()
          .WithIdentity(RuleId + " Retry " + RetryCount, "SnapshotJob")
          .ForJob(jobDetail)
          .StartAt(DateTime.Now.AddMinutes(1))
          .UsingJobData("RuleId", RuleId)
          .UsingJobData("RetryCount", ++RetryCount)
          .Build();

        scheduler.ScheduleJob(trigger).Wait();
      }

      else
        throw new JobExecutionException(ex, false);
    }
  }
}
