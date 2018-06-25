using Akka.Actor;
using Monitoring.Core.Messages.MonitorMessages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Actors
{
    public class SystemActor : ReceiveActor
    {
        private readonly Dictionary<string, IActorRef> _motinorActors;
        public SystemActor()
        {
            _motinorActors = new Dictionary<string, IActorRef>();

            Receive<FtpFileMonitorMessage>(m => StartFtpFileMonitor(m));
            Receive<PowerShellMonitorMessage>(m => StartPowerShellMonitor(m));
        }

        private void StartFtpFileMonitor(FtpFileMonitorMessage message)
        {

        }

        private void StartPowerShellMonitor(PowerShellMonitorMessage message)
        {

        }
    }
}
