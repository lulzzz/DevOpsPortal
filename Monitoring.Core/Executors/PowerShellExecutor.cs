using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;

namespace Monitoring.Core.Executors
{
    class PowerShellExecutor
    {
        private readonly string _executionContext;
        public PowerShellExecutor(string executionContext)
        {
            _executionContext = executionContext;
        }
        public ResultModel ExcuteScript(string script)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                
                var results = ps.AddScript(script).Invoke();

                if (true)
                {
                    return new ResultModel(ResultEnum.Unknown, 0);
                }
                
                foreach (var result in results)
                {
                    if ()
                    {

                    }
                }

                
            }

                
        }
        
    }
}
