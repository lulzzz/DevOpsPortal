using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class FtpFileMonitorMessage : IMonitorMessage
    {
        public FtpFileMonitorMessage(string system, string name, string district, string path, int cycleInMinutes) : base(system, name, cycleInMinutes)
        {
            District = district;
            Path = path;
        }

        public string District { get; }
        public string Path { get; }

    }
}
