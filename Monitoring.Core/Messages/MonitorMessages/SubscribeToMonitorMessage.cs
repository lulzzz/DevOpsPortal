using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class SubscribeToMonitorMessage : ISubscribeMonitorMessage
    {
        public SubscribeToMonitorMessage(string name, string system, IActorRef subscriberReference) :base(system)
        {
            Name = name;
            SubscriberReference = subscriberReference;
        }

        public string Name { get; }
        public IActorRef SubscriberReference { get; }
    }
}
