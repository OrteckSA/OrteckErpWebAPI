using ERP.Domain.UnitOfWork;
using ERP.Repository.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebAPI.Services.Common
{
    public class CheckDatabaseService
    {
        IServiceProvider ServiceProvider { get; set; }
        public const int CURRENT_DB_VERSION = 169;

        public CheckDatabaseService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        public bool CheckDatabaseVersion()
        {
            var context = ServiceProvider.GetService<ERPContext>();
            using (context)
            {
                if(context.GetDBVersion() == CURRENT_DB_VERSION)
                    return true;
            }
            return false;
        }
    }
}
