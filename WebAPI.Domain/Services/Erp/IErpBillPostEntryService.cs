using ERP.Domain.Entity;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpBillPostEntryService
    {
        Task InsertPostBillWithEntry(Bill bill, BillType type);
    }
}
