using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class UnsubscribeFromAllMonitorsMessage : ISubscribeMonitorMessage
    {
        public UnsubscribeFromAllMonitorsMessage(string system, string name) : base(system, name)
        {

        }
    }
}
