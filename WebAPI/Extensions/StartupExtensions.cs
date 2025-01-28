
using ERP.WebAPI.Services;
using ERP.WebAPI.Services.Model;
using Hangfire;

namespace ERP.WebAPI.Extensions
{
    public static class StartupExtensions
    {
        public static void SetServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApiServices(configuration);

            var connectionStrings = configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();
            //services.AddHangfire(x => x.UseSqlServerStorage(connectionStrings.HangfireConnection));
            //services.AddHangfireServer(options =>
            //{
            //    options.Queues = new[] { "payments", "syncToLocal" ,"transactions", "default"};
            //    options.WorkerCount = 1;
            //});

            //services.AddAuthentication();

        }
    }
}
