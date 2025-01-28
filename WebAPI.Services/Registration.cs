using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ERP.WebAPI.Services.Common;
using NReco.Logging.File;
using Microsoft.Extensions.Logging;
using DAL.Services;
using DAL.Services.BillServices;
using DAL.Services.Permissions;
using DAL.Services.Settings;
using DAL.Services.MaterialServices;
using DAL.Services.CacheService;
using DAL.Services.Stock;
using DAL.Services.Common;
using ERP.WebAPI.Services.Model;
using ERP.Domain.UnitOfWork;
using ERP.Repository.UnitOfWork;
using System.Formats.Asn1;
using Common.Domain.UnitOfWork;
using ERP.Repository.Context;
using ERP.Domain.Entity;

namespace ERP.WebAPI.Services
{
    public static class Registration
    {
        public static void AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Transactions
            var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
            services.AddSingleton(appSettings);
            //Integration
            FileLoggerOptions opts = new FileLoggerOptions();
            opts.Append = true;
            opts.FileSizeLimitBytes = 1024 * 1024 * 50;//1mb for each file
            opts.FormatLogFileName = fName => string.Format(fName, DateTime.UtcNow);

            FileLogger logger = new FileLogger("Logger",new FileLoggerProvider("app_{0:yyyy}-{0:MM}.log",opts));
            //services.AddERPServices(configuration);

            services.AddSingleton<ILogger>(logger);

            //services.AddERPServices(configuration);

            services.AddSingleton<UserContext>(new UserContext
            {
                CurrentUser = new User {  LoginName = "Admin" }
            });

            services.AddScoped<ERPContext>();
            services.AddScoped<IErpUnitOfWork, ERPUnitOfWork>();
            services.AddScoped<BillService>();

            services.AddScoped<IBillTypeService, BillTypeService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialComponentService, MaterialComponentService>();
            services.AddScoped<UserService>();
            services.AddScoped<IOptionService, OptionsService>();
            services.AddScoped<CurrencyService>();
            services.AddScoped<IERPSettings, ERPSettings>();
            services.AddScoped<PermissionService>();
            services.AddScoped<MaterialBatchService>();
            services.AddScoped<CheckDatabaseService>();
            services.AddScoped<IStockTransferService, StockTransferService>();
            services.AddScoped<IProductionOrderService, ProductionOrderService>();
            services.AddSingleton<ICacheService, MemoryCacheService>();


        }
    }
}
