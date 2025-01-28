using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Enums.Integration
{
    public enum TransactionType
    {
        Invoice = 0,
        ItemsLoad = 1,
        ItemsUnLoad = 2,
        ReturnInvoice = 3,
    }
    public enum TransactionSubmitStatus
    {
        NotSubmitted,
        Submitted
    }
    public enum TransactionRequest
    {
        WaitingForSubmit = 0,
        Submitting = 1,
        Error = 2,
        Success = 3,
        Rejected = 4
    }
    public enum TransactoinViewStatus
    {
        All,Pending,Error,Done,Deleted
    }
}
