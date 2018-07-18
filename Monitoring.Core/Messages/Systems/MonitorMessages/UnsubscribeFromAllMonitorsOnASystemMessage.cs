using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class UnsubscribeFromAllMonitorsOnASystemMessage : ISubscribeMonitorMessage
    {
        public UnsubscribeFromAllMonitorsOnASystemMessage(string system) : base(system, "all")
        {

        }


    }
}
