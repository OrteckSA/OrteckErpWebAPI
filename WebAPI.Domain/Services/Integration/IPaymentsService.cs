using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IPaymentsService
    {
        Task SubmitSalesPaymentsToLocal();
        Task InsertPayment(PaymentSales salesPayment);
        Task<PaymentPagingViewModel> GetPaymentsViewModel(int statusId, int pageSize, int skip);
    }
}
