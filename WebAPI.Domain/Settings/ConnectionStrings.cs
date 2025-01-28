using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Settings
{
    public class ConnectionStrings
    {
        public string TransactionConnection { get; set; }
        public string IntegrationConnection { get; set; }
        public string ErpConnection { get; set; }
        public string HangfireConnection { get; set; }

    }
}
