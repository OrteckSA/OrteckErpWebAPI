using ERP.Domain.Entity;
using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Entity.Sales;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpMaterialService
    {
        Task<Guid> InsertMaterial(TransactionDetail transactionDetail);
        Task<Guid> InsertMatDetail(Guid materialGuid, string size);
    }
}
