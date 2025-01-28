using ERP_Integration.Domain.Entity.Qutation;
using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Qutation
{
    public interface IQutationInvoiceHeaderService
    {
        Task<List<InvoiceHeader>> GetInvoiceHeaderNotSubmitted(int size);
        Task UpdateSubmitted(InvoiceHeader invoiceHeader);
    }
}
