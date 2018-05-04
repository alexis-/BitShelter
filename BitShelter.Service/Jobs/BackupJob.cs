using BitShelter.Utils;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.Service.Jobs
{
  public class BackupJob : IJob
  {
    public Task Execute(IJobExecutionContext context)
    {
      return TaskConst.Completed;
    }
  }
}
