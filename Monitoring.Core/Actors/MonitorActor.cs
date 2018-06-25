using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Actors
{
    public class MonitorActor : ReceiveActor
    {
        public MonitorActor()
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
