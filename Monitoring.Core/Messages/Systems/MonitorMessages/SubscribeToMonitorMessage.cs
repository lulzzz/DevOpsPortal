using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class SubscribeToMonitorMessage : ISubscribeMonitorMessage
    {
        public SubscribeToMonitorMessage(string name, string system, IActorRef subscriberReference) :base(system, name)
        {
           SubscriberReference = subscriberReference;
        }

       
        public IActorRef SubscriberReference { get; }
    }
}
