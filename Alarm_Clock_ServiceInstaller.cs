using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Alarm_Clock_Service
{
    [RunInstaller(true)]
    public partial class Alarm_Clock_ServiceInstaller : System.Configuration.Install.Installer
    {
        public Alarm_Clock_ServiceInstaller()
        {
            InitializeComponent();
            this.AfterInstall += Alarm_Clock_ServiceInstaller_AfterInstall;
            this.AfterRollback += Alarm_Clock_ServiceInstaller_AfterRollback;
        }

        private void Alarm_Clock_ServiceInstaller_AfterRollback(object sender, System.Configuration.Install.InstallEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed!");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void Alarm_Clock_ServiceInstaller_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
