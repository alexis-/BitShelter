using MyPreciousData.Data;
using MyPreciousData.Models;
using MyPreciousData.Service.Scheduler;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Service
{
  public class ServiceAppHost : IAppHost
  {
    public RulesConfigModified GetRulesConfigModifiedCallback()
    {
      return new RulesConfigModified(RulesConfigModified);
    }

    public void OnPostInitialize()
    {
    }

    public void OnPreInitialize()
    {
      // This allows rules to turned into Quartz IJobDetails & ITriggers; both at App startup when
      // RuleMgr is initialized with the latest rules, and when RulesConfigModified is called
      RuleMgr.Instance.RulesUpdated += VssScheduler.CreateTriggers;
    }

    public void RulesConfigModified(IList<SnapshotRule> rules)
    {
      Log.Information("Loading updated rules configuration.");

      RuleMgr.Instance.LoadRules(rules);
    }
  }
}
