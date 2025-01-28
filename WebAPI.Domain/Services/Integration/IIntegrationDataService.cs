using ERP.Domain.Entity;
using ERP_Integration.Domain.Model.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IIntegrationDataService
    {
        public Task<Material> GetOrInsertMaterial(string id);
        public Task<SalesPerson> GetOrInsertSalesPerson(string id);
        public Task<Customer> GetOrInsertCustomer(string id);
        public Task<Store> GetOrInsertStore(string id);
    }
}
