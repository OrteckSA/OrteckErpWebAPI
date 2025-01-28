using ERP.Domain.Entity;
using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Erp
{
    public interface IErpCustomerService
    {
        Task<Account> CheckCustomerAccount(Customer customer);
        Task InsertCustomer(Customer customer);
    }
}
