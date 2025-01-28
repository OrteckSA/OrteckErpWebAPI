using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IIntegrationErpUserService
    {
        public Task LoginToIntegrationUser();
    }
}
