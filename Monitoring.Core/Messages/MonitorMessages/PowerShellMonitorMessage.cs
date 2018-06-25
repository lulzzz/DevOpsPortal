using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class PowerShellMonitorMessage : IMonitorMessage
    {
        public PowerShellMonitorMessage(string system, string name, string powershellScript):base(system, name)
        {
            PowerShellScript = powershellScript;
            
        }

        public string PowerShellScript { get; }
    }
}
