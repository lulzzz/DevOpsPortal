using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class PowerShellMonitorMessage : IMonitorMessage
    {
        public PowerShellMonitorMessage(string system, string name,int cycleInMinutes, string powershellScript, string executionContext = "localhost"):base(system, name, cycleInMinutes)
        {
            PowerShellScript = powershellScript;
            ExecutionContext = executionContext;
        }

        public string PowerShellScript { get; }
        public string ExecutionContext { get; }
    }
}
