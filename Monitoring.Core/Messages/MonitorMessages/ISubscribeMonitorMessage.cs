using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class ISubscribeMonitorMessage
    {
        public ISubscribeMonitorMessage(string system)
        {
            System = system;
        }

        public string System { get; }
    }
}
