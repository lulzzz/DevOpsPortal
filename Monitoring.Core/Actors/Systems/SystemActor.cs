using Akka.Actor;
using Monitoring.Core.Messages.MonitorMessages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Actors.Systems
{
    public class SystemActor : ReceiveActor
    {
        private readonly Dictionary<string, IActorRef> _monitorActors;
        public SystemActor()
        {
            _monitorActors = new Dictionary<string, IActorRef>();

            Receive<IMonitorMessage>(m => CreateMonitorActor(m));
            Receive<SubscribeToAllMonitorsOnASystemMessage>(m => SubscribeToAllMonitors(m));
            Receive<ISubscribeMonitorMessage>(m => PassSubscription(m));
            Receive<UnsubscribeFromAllMonitorsOnASystemMessage>(m => UnsubscribeFromAllMonitors(m));

        }

        private void CreateMonitorActor(IMonitorMessage message)
        {
            MonitorRegistration(message.Name);

            _monitorActors[message.System].Tell(message);

        }
        private void PassSubscription(ISubscribeMonitorMessage message)
        {
            MonitorRegistration(message.Name);

            _monitorActors[message.System].Tell(message);

        }

        private void SubscribeToAllMonitors(SubscribeToAllMonitorsOnASystemMessage message)
        {
            foreach (var monitor in _monitorActors)
            {
                monitor.Value.Tell(message);
            }
        }

        private void UnsubscribeFromAllMonitors(UnsubscribeFromAllMonitorsOnASystemMessage message)
        {
            foreach (var monitor in _monitorActors)
            {
                monitor.Value.Tell(message);
            }
        }

         

        private void MonitorRegistration(string monitor)
        {
            var createSystem = !_monitorActors.ContainsKey(monitor);

            if (createSystem)
            {
                IActorRef newChildActor = Context.ActorOf(
                    Props.Create(
                        () => new SystemActor()),
                        monitor
                    );

                _monitorActors.Add(monitor, newChildActor);
            }

        }
    }
}
