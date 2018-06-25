using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Messages.MonitorMessages
{
    public class FtpFileMonitorMessage : IMonitorMessage
    {
        public FtpFileMonitorMessage(string system, string name, string district, string path, int checkTimeInMinutes) : base(system, name)
        {
            District = district;
            Path = path;
            CheckTimeInMinutes = checkTimeInMinutes;
        }

        public string District { get; }
        public string Path { get; }
        public int CheckTimeInMinutes { get; }

    }
}
