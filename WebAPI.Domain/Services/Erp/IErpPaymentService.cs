using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpPaymentService
    {
        Task<ResultViewModel> InsertPayment(int paymentId, Guid userId);
    }
}
