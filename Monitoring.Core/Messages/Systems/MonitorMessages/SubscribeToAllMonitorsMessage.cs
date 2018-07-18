using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class SubscribeToAllMonitorsMessage : ISubscribeMonitorMessage
    {
        public SubscribeToAllMonitorsMessage() : base("all", "all")
        {

        }
    }
}
