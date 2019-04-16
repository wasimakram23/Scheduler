using Quartz;

namespace Icp.Schedule
{
    public class ScheduleJobListener : IJobListener
    {
        public event TaskExecution Started;
        public event TaskExecution Vetoed;
        public event TaskExecutionComplete Executed;

        public ScheduleJobListener(string name)
        {
            Name = name;
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Started?.Invoke();
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Vetoed?.Invoke();
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Executed?.Invoke(jobException);
        }

        public string Name { get; }
    }
}