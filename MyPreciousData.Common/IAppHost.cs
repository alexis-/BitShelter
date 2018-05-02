using MyPreciousData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData
{
  public delegate void RulesConfigModified(IList<SnapshotRule> rules);

  public interface IAppHost
  {
    void OnPreInitialize();
    void OnPostInitialize();

    RulesConfigModified GetRulesConfigModifiedCallback();
  }
}
