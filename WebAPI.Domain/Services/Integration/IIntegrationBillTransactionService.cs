using ERP.Domain.Entity;
using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Model.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IIntegrationBillTransactionService
    {
        Task CheckInvoiceBill(GeneralTransaction transaction, Bill bill);
        public Task<bool> IsTransactionChanged(Transaction transaction);
    }
}
