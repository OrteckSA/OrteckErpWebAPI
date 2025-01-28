using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Sales
{
    public interface ISalesPaymentService
    {
        Task<List<PaymentSales>?> GetSalesPaymentNotSubmitted(int size);
        Task UpdateSuccessfullySubmitted(PaymentSales salesPayment);
    }
}
