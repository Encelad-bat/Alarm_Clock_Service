using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Alarm_Clock_Service
{
    public partial class Service1 : ServiceBase
    {
        private string path = "";

        private readonly Timer timer = new Timer();

        public Service1()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanShutdown = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;


            foreach (var drive in Environment.GetLogicalDrives())
            {
                if (Directory.Exists(drive + "Program Files\\Alarm Clock"))
                {
                    this.path = Directory.GetFiles(drive + "Program Files\\Alarm Clock", "TimeDate Application.exe", SearchOption.AllDirectories)[0];
                    break;
                }
            }

            timer.Start();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Process.GetProcessesByName("TimeDate Application").Length == 0 || Process.GetProcessesByName("TimeDate Application").Length == 1)
            {
                Process.Start(path);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
