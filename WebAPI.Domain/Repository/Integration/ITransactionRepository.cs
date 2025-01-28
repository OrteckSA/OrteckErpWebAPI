using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Entity.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Repository.Integration
{
    public interface ITransactionRepository
    {
        Task InsertSalesOrder(Transaction salesOrder);
    }
}
