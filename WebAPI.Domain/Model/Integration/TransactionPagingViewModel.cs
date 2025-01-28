using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class TransactionPagingViewModel 
    {
        public IList<TransactionViewModel>? List { get; set; }

        public int Count { get; set; }
       
    }
}
