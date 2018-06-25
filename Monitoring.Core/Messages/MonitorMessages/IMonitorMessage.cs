using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class IMonitorMessage
    {
        public IMonitorMessage(string system, string name, int cycleInMinutes)
        {
            System = system;
            Name = name;
            CycleInMinutes = cycleInMinutes;

        }

        public string System { get; }
        public string Name { get;  }
        public int CycleInMinutes { get; }
    }
}
