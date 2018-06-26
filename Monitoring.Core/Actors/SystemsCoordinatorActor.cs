using System;
using System.Collections.Generic;
using System.Text;
using Akka.Actor;
using Monitoring.Core.Messages.MonitorMessages;

namespace Monitoring.Core.Actors
{
    public class SystemsCoordinatorActor : ReceiveActor
    {
        // Store of all of the systems this supervisor will be a parent of.
        private readonly Dictionary<string, IActorRef> _systemActors;

        public SystemsCoordinatorActor()
        {
            _systemActors = new Dictionary<string, IActorRef>();

            Receive<IMonitorMessage>(m => SendMonitorMessageToSystem(m));
            Receive<ISubscribeMonitorMessage>(m => PassSubscription(m));
            Receive<SubscribeToAllMonitorsMessage>(m => SubscribeToAllMonitors(m));
            Receive<UnsubscribeFromAllMonitorsMessage>(m => UnsubscribeFromAllMonitors(m));            

        }     

        private void SendMonitorMessageToSystem(IMonitorMessage message)
        {
            SystemRegistration(message.System);

            _systemActors[message.System].Tell(message);
        }

        private void PassSubscription(ISubscribeMonitorMessage message)
        {
            SystemRegistration(message.System);

            _systemActors[message.System].Tell(message);

        }

        private void SubscribeToAllMonitors(SubscribeToAllMonitorsMessage message)
        {
            foreach (var system in _systemActors)
            {
                system.Value.Tell(message);
            }
        }

        private void UnsubscribeFromAllMonitors(UnsubscribeFromAllMonitorsMessage message)
        {
            foreach (var system in _systemActors)
            {
                system.Value.Tell(message);
            }
        }

        private void SystemRegistration(string system)
        {
            var createSystem = !_systemActors.ContainsKey(system);

            if (createSystem)
            {
                IActorRef newChildActor = Context.ActorOf(
                    Props.Create(
                        () => new SystemActor()),
                        system
                    );

                _systemActors.Add(system, newChildActor);
            }

        }
    }
}
