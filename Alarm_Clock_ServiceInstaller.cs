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
        }
    }
}
