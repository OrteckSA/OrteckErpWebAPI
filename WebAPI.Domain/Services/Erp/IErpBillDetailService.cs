using ERP.Domain.Entity;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpBillDetailService
    {
        Task InsertBillDetail(Guid billGuid, Guid currencyGUID, BillType? billType);
    }
}
