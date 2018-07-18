using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Executors
{
    public class IExecutor
    {
        public IExecutor(string executorType)
        {
            ExecutorType = executorType;
        }
        public string ExecutorType { get; }
    }
}
