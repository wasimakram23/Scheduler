using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading;
using Icp.Schedule;
using Quartz;

namespace Sched.Test
{

    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class SchedTestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            int jobDuration = Convert.ToInt32(ConfigurationManager.AppSettings["JobDurationMilliseconds"]);
            Thread.Sleep(jobDuration);
        }
    }

    public class TestSchedule : Schedule
    {
        public TestSchedule(IScheduler scheduler) : base(scheduler, "SchedTestJob")
        {
        }

        public void Start()
        {
            string cronJobExpression = ConfigurationManager.AppSettings["CronJobExpression"];
            TriggerBuilder triggerBuilder = TriggerBuilder.Create().WithCronSchedule(cronJobExpression);
            JobBuilder jobBuilder = JobBuilder.Create<SchedTestJob>();
            ScheduleTask(jobBuilder, triggerBuilder);
            AttachJobListener();
        }
    }

    public class TestScheduleContext : ScheduleContext
    {
        private TestSchedule _uploader;

        public TestSchedule UploaderSchedule
        {
            get
            {
                _uploader = _uploader ?? new TestSchedule(Scheduler);
                return _uploader;
            }
        }

        public TestScheduleContext()
        {
            Props = new NameValueCollection
            {
                //{"quartz.scheduler.interruptJobsOnShutdownWithWait", "true"},
                {"quartz.scheduler.instanceName", nameof(TestScheduleContext)}
            };
            Start();
        }
    }
}
