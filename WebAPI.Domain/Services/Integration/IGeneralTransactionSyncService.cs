using ERP_Integration.Domain.Enums.Integration;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IGeneralTransactionSyncService
    {
        Task SyncLoadItemsToLocal();
        Task SyncToLoadItemsToLocalSafeCheck();
        Task SyncToReturnInvoiceToLocal();
        Task SyncToReturnInvoiceToLocalSafeCheck();
        Task SyncToInvoiceToLocal();
        Task SyncToInvoiceToLocalSafeCheck();
    }
}
