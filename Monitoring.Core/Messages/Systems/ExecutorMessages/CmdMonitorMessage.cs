using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class CmdMonitorMessage : IMonitorMessage
    {
        public CmdMonitorMessage(string system, string name, int cycleInMinutes, string command) : base(system, name, cycleInMinutes)
        {
            Command = command;
        }

        public string Command { get; }
    }
}
