using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Enums.Integration
{
    public enum SubmittedToErpStatusEnum
    {
        ALL = 0,
        PENDING = 1,
        ERROR = 2,
        DONE = 3,
        DELETED = 4,
    }
}
