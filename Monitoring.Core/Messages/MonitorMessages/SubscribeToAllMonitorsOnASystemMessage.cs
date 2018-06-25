using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class SubscribeToAllMonitorsOnASystemMessage : ISubscribeMonitorMessage
    {
        public SubscribeToAllMonitorsOnASystemMessage(string system) : base(system)
        {
           
        }

    }
}
