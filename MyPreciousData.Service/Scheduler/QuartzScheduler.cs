using Quartz;
using Quartz.Impl;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace MyPreciousData.Service.Scheduler
{
  // https://www.quartz-scheduler.net/documentation/quartz-3.x/quick-start.html
  // https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/index.html
  // https://github.com/damianh/LibLog/wiki
  class QuartzScheduler
  {
    public IScheduler Scheduler { get; private set; }

    protected static QuartzScheduler _instance = null;
    public static QuartzScheduler Instance
    {
      get
      {
        return _instance ?? (_instance = new QuartzScheduler());
      }
    }

    protected QuartzScheduler() { }

    public async Task Start()
    {
      // construct a scheduler factory
      NameValueCollection props = new NameValueCollection
      {
        { "quartz.serializer.type", "binary" }
      };
      StdSchedulerFactory schedFact = new StdSchedulerFactory(props);

      // get a scheduler
      Scheduler = await schedFact.GetScheduler();
      await Scheduler.Start();
    }

    public async Task Shutdown()
    {
      await Scheduler.Shutdown();
    }
  }
}
