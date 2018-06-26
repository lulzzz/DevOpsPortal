using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Core.Executors
{
    class ResultModel
    {
        public ResultModel(ResultEnum result, int executionTime)
        {
            Result = result;
            ExecutionTime = executionTime;
        }
        public ResultEnum Result { get; }
        public int ExecutionTime { get; }
    }

    enum ResultEnum
    {
        Ok,
        Warning,
        Critical,
        Unknown
    }
}
