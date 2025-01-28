﻿using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface ICustomerErpSalesIntegrationService
    {
        Task SyncCustomerErpWithIntegration();
        Task SyncCustomerErpWithSales();
    }
}
