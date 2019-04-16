using Icp.Ui.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sched.Test
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker bw;
        private uint _maxLine = 720;
        private TestScheduleContext _scheduleContext;

        public Form1()
        {
            InitializeComponent();

            bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += StartScheduler;
            bw.RunWorkerCompleted += BgWorkerCompleted;
            bw.RunWorkerAsync();
        }


        private void StartScheduler(object sender, DoWorkEventArgs e)
        {
            /*close background worker*/
            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            _scheduleContext = new TestScheduleContext();
            _scheduleContext.UploaderSchedule.TaskStarted += BeforeStart;
            _scheduleContext.UploaderSchedule.TaskExecuted += AfterEnd;
            _scheduleContext.UploaderSchedule.Start();
            Estimated(_scheduleContext.UploaderSchedule.NextFireTime());
        }

        private void BgWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                LogManager.WriteErrorLog("SchedulerTest", e.Error);

                this.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AddLine("Error to Run!");
                    richTextBox1.ScrollToCaret();
                });
            }
        }

        private void Estimated(DateTime? dateTime)
        {
            string msg = "Estimated: ";
            if (dateTime != null)
            {
                msg += ((DateTime)dateTime).ToString("dd-MMM-yyyy hh:mm:ss tt");
            }

            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AddLine(msg, _maxLine);
                richTextBox1.ScrollToCaret();
            });
        }

        private void BeforeStart()
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText("\t\t" + "Started: " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt"));
                richTextBox1.ScrollToCaret();
            });
        }

        private void AfterEnd(Exception exception)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText("\t\t" + "Ended: " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt"));
                richTextBox1.ScrollToCaret();
            });

            string status = String.Empty;
            if (exception != null)
            {
                status = "Error";
                LogManager.WriteErrorLog("SchedulerTest", exception);
            }
            else
            {
                status = "Success";
            }
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText("\t\t" + "Result: " + status);
                richTextBox1.ScrollToCaret();
            });

            Estimated(_scheduleContext.UploaderSchedule.NextFireTime());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_scheduleContext.UploaderSchedule.IsTaskRunning())
            {
                var window = MessageBox.Show(
                    "The task is in progress, do you still want to close?",
                    "Close Window",
                    MessageBoxButtons.YesNo);
                if (window == DialogResult.Yes)
                {
                    CloseApp();
                }
                e.Cancel = (window == DialogResult.No);
            }
            else
            {
                CloseApp();
            }
        }

        private void CloseApp()
        {
            /*stop shedule*/
            _scheduleContext.Stop();

            /*close backgraound worker
             *https://stackoverflow.com/questions/4732737/how-to-stop-backgroundworker-correctly
             */
            if (bw.IsBusy)
            {
                bw.CancelAsync();
            }
            while (bw.IsBusy)
            {
                Application.DoEvents();
            }

            /*kill all running process
             * https://stackoverflow.com/questions/8507978/exiting-a-c-sharp-winforms-application
             */
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            Environment.Exit(0);
        }

    }
}
