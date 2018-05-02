using MyPreciousData.Models;
using MyPreciousData.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Data
{
  public delegate void RulesUpdated(IEnumerable<SnapshotRule> rules);

  public class RuleMgr
  {
    // Concurrent operations shouldn't be an issue, these collections only get updated in the Agent
    protected BindingList<SnapshotRule> RuleCollection { get; set; }
    //protected ReadOnlyObservableCollection<SnapshotRule> RuleCollectionRO { get; set; }

    protected RuleMgr()
    {

    }

    protected static RuleMgr _instance = null;
    public static RuleMgr Instance => _instance ?? (_instance = new RuleMgr());


    public event RulesUpdated RulesUpdated;

    public void LoadRules(IList<SnapshotRule> rules)
    {      
      RuleCollection = new BindingList<SnapshotRule>(rules);
      //RuleCollectionRO = new ReadOnlyBindingList<SnapshotRule>(RuleCollection);

      RulesUpdated?.Invoke(rules);
    }

    public void AddOrUpdateRule(SnapshotRule newRule)
    {
      SnapshotRule oldRule = RuleCollection.FirstOrDefault(r => r.Id == newRule.Id);

      if (oldRule != null)
      {
        newRule.CopyProperties(oldRule);

        return;
      }

      RuleCollection.Add(newRule);
    }

    public bool RuleNameExists(string ruleName) => RuleCollection.Any(r => r.Name == ruleName);
    public SnapshotRule GetRule(long ruleId) => RuleCollection.FirstOrDefault(r => r.Id == ruleId);
    public BindingList<SnapshotRule> Rules => RuleCollection;
    //public ReadOnlyObservableCollection<SnapshotRule> Rules => RuleCollectionRO;
  }
}
