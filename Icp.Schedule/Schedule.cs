using System;
using System.Linq;
using Quartz;
using Quartz.Impl.Matchers;

namespace Icp.Schedule
{
    public interface ISchedule
    {

    }

    public abstract class Schedule : ISchedule
    {
        public event TaskExecution TaskStarted;
        public event TaskExecution TaskVetoed;
        public event TaskExecutionComplete TaskExecuted;


        private readonly IScheduler Scheduler;

        public readonly string Name;
        private string TriggerName
        {
            get
            {
                return Name + "Trigger";
            }
        }
        private string JobName
        {
            get
            {
                return Name + "Job";
            }
        }
        private string ListenerName
        {
            get
            {
                return Name + "Listener";
            }
        }
        
        protected Schedule(IScheduler scheduler, string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Schedule Name required");
            }
            if (scheduler == null)
            {
                throw new NullReferenceException("Scheduler required");
            }

            Name = name;
            Scheduler = scheduler;
        }

        /// <summary>
        /// this is not cluster aware
        /// </summary>
        /// <returns></returns>
        /*https://stackoverflow.com/questions/24568282/check-whether-the-job-is-running-or-not*/
        public bool IsTaskRunning()
        {
            bool value = Scheduler.GetCurrentlyExecutingJobs().Any(x =>
                x.JobDetail.Key.Name.Equals(JobName, StringComparison.OrdinalIgnoreCase));
            return value;
        }

        /*https://stackoverflow.com/questions/21527841/schedule-multiple-jobs-in-quartz-net*/

        protected void ScheduleTask(JobBuilder jobBuilder, TriggerBuilder triggerBuilder)
        {
            IJobDetail job = jobBuilder.WithIdentity(JobName).Build();
            ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
            Scheduler.ScheduleJob(job, trigger);
        }

        private TriggerBuilder AssignTriggerName(TriggerBuilder triggerBuilder)
        {
            return triggerBuilder.WithIdentity(TriggerName);
        }

        //public abstract void Start();

        public void Pause()
        {
            Scheduler.PauseJob(new JobKey(JobName));
        }

        public void Resume()
        {
            Scheduler.ResumeJob(new JobKey(JobName));
        }

        /*
         * https://stackoverflow.com/questions/16334411/quartz-net-rescheduling-job-with-new-trigger-set
         */
        protected void Reschedule(TriggerBuilder triggerBuilder)
        {
            TriggerKey key = new TriggerKey(TriggerName);
            ITrigger trigger = AssignTriggerName(triggerBuilder).Build();
            Scheduler.RescheduleJob(key, trigger);
        }
		
		/*
		*https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/trigger-and-job-listeners.html
		*/
        protected void AttachJobListener()
        {
            ScheduleJobListener myJobListener = new ScheduleJobListener(ListenerName);
            myJobListener.Started += TaskStarted;
            myJobListener.Vetoed += TaskVetoed;
            myJobListener.Executed += TaskExecuted;
            Scheduler.ListenerManager.AddJobListener(myJobListener, KeyMatcher<JobKey>.KeyEquals(new JobKey(JobName)));
        }

        public DateTime? NextFireTime()
        {
            TriggerKey key = new TriggerKey(TriggerName);
            DateTimeOffset? timeUtc = Scheduler.GetTrigger(key).GetNextFireTimeUtc();
            DateTime? dateTime = timeUtc == null 
                                    ? (DateTime?) null 
                                    : timeUtc.Value.ToLocalTime().DateTime;

            return dateTime;
        }
    }         

}