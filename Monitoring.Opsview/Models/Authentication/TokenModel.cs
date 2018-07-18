using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Opsview.Models.Authentication
{
    public class TokenModel : OpsviewResponseBase
    {
        public string token { get; set; }
    }
}
