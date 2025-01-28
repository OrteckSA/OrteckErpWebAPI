using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IRequestTypeMapService
    {
        Task<RequestTypeMap?> GetRequestTypeMapAsync(string requestTypeName);

    }
}
