using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpBillService
    {
        Task<ResultViewModel> InsertBillFromTransaction(int transactionId, Guid userId);
        Task<ResultViewModel> InsertBillFromGeneralTransaction(GeneralTransaction transaction);
        Task<ResultViewModel> CreateProductionOrderForMaterials(List<MaterialQty> items);
    }
}
