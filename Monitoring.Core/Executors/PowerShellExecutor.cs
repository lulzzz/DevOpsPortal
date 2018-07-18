using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Monitoring.Core.Executors
{
    class PowerShellExecutor : IExecutor
    {
        private readonly string _executionContext;
        public PowerShellExecutor(string executionContext) : base("powershell")
        {
            _executionContext = executionContext;
        }
        public ResultModel ExcuteScript(string script)
        {
            WSManConnectionInfo connectionInfo = new WSManConnectionInfo();

            if (!(_executionContext.ToLower() == "localhost"))
            {
                connectionInfo.ComputerName = _executionContext;
            }

            using (PowerShell ps = PowerShell.Create())
            {
                Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo);
                runspace.Open();
                ps.Runspace = runspace;
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
