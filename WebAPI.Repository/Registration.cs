using Common.Domain.UnitOfWork;
using ERP.Domain.UnitOfWork;
using ERP.Repository.Context;
using ERP.Repository.UnitOfWork;
using ERP_Integration.Domain.Entity.Account;
using ERP_Integration.Domain.Enums;
using ERP_Integration.Domain.Settings;
using ERP_Integration.Domain.UnitOfWork;
using ERP_Integration.Repository.Context;
using ERP_Integration.Repository.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ERP.Repository;
namespace ERP_Integration.Repository
{
    public static class Registration
    {
        public static void AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionStrings = configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            services.AddSingleton(connectionStrings);

            var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
            services.AddSingleton(appSettings);

            services.AddDbContextPool<IntegrationContext>(x => x.UseSqlServer(connectionStrings.IntegrationConnection));
            //services.AddDbContext<ERPContext>(x => x.UseSqlServer(connectionStrings.ErpConnection));
            ERPContext.ConnectionString = connectionStrings.ErpConnection;
            services.AddErpUnitOfWork(configuration);

            //Transaction
            if (appSettings.TransactionClientName == TransactionClientName.Sales.ToString())
            {
                services.AddDbContextPool<SalesContext>(options => options.UseMySql(connectionStrings.TransactionConnection, ServerVersion.AutoDetect(connectionStrings.TransactionConnection)));
                services.AddScoped<ISalesUnitOfWork, SalesUnitOfWork>();
            }
            else if (appSettings.TransactionClientName == TransactionClientName.Qutation.ToString())
            {
                services.AddDbContextPool<QutationContext>(x => x.UseSqlServer(connectionStrings.TransactionConnection));
                services.AddScoped<IQutationUnitOfWork, QutationUnitOfWork>();
            }

            services.AddScoped<IIntegrationUnitOfWork, IntegrationUnitOfWork>();
            //services.AddScoped<IErpUnitOfWork, ERPUnitOfWork>();


            //services.AddSingleton(provider => new ERPUnitOfWork(connectionStrings.ErpConnection));
            //services.AddSingleton<IErpUnitOfWork>(provider => provider.GetService<ERPUnitOfWork>());

            //services.AddSingleton(provider => new IntegrationUnitOfWork(connectionStrings.IntegrationConnection));
            //services.AddSingleton<IIntegrationUnitOfWork>(provider => provider.GetService<IntegrationUnitOfWork>());

            ////Transaction
            //if (appSettings.TransactionClientName == TransactionClientName.Sales.ToString())
            //{
            //    services.AddSingleton(provider => new SalesUnitOfWork(connectionStrings.TransactionConnection));
            //    services.AddSingleton<ISalesUnitOfWork>(provider => provider.GetService<SalesUnitOfWork>());
            //}
            //else if (appSettings.TransactionClientName == TransactionClientName.Qutation.ToString())
            //{
            //    services.AddSingleton(provider => new QutationUnitOfWork(connectionStrings.TransactionConnection));
            //    services.AddSingleton<IQutationUnitOfWork>(provider => provider.GetService<QutationUnitOfWork>());
            //}

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<IdentityAppContext>();

            services.AddDbContextPool<IdentityAppContext>(c => c.UseSqlServer(connectionStrings.IntegrationConnection));

        }
    }
}
