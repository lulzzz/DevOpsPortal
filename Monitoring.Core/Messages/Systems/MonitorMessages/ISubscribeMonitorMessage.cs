using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class ISubscribeMonitorMessage
    {
        public ISubscribeMonitorMessage(string system, string name)
        {
            System = system;
            Name = system;
        }

        public string Name { get; }
        public string System { get; }
    }
}
