using System;
using System.ComponentModel;

namespace Icp.Ui.Core
{
    public class ProcessHelper
    {
        public delegate void Status();
        public event Status BeforeStart;
        public event Status Task;
        public event Status AfterEnd;

        public void Start(object sender, DoWorkEventArgs e)
        {
            BeforeStart?.Invoke();
            Task?.Invoke();           
            AfterEnd?.Invoke();
        }
    }
}
