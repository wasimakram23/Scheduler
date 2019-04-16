using System;

namespace Icp.Schedule
{
    public delegate void TaskExecution();
    public delegate void TaskExecutionComplete(Exception exception);
}
