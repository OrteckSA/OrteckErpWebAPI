using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using ERP_Integration.Domain.Settings;
using ERP_Integration.SalesRepository.Context;

namespace ERP_Integration.SalesRepository
{
    public static class Registration
    {
        public static void AddSalesRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            var settings = configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            services.AddSingleton(settings);

            services.AddDbContext<SalesContext>(options => options.UseMySQL(settings.SalesConnection));

        }
    }
}
