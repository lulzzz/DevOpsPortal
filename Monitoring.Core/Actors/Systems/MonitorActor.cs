using Akka.Actor;
using Monitoring.Core.Messages.MonitorMessages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Actors.Systems
{
    public class MonitorActor : ReceiveActor
    {
        public MonitorActor()
        {
            Receive<FtpFileMonitorMessage>(m => StartFtpFileMonitor(m));
            Receive<PowerShellMonitorMessage>(m => StartPowerShellMonitor(m));
            Receive<CmdMonitorMessage>(m => StartCmdMonitor(m));
        }

        private void StartFtpFileMonitor(FtpFileMonitorMessage message)
        {

        }

        private void StartPowerShellMonitor(PowerShellMonitorMessage message)
        {

        }
        private void StartCmdMonitor(CmdMonitorMessage message)
        {

        }

        protected override void PreStart()
        {
            base.PreStart();
        }

        protected override void PostStop()
        {
            base.PostStop();
        }
    }
}
