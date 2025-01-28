using DAL.Services;
using ERP.Domain.Entity;
using ERP.Domain.UnitOfWork;
using ERP.Domain.Utils;
using ERP.WebAPI.Extensions;
using ERP.WebAPI.Filters;
using ERP.WebAPI.Services.Common;
using Hangfire;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();


// Add services to the container.
builder.Services.AddControllers();

builder.Services.SetServices(builder.Configuration);
builder.Services.AddDataProtection()
        .PersistKeysToFileSystem(new DirectoryInfo(@"UNC-PATH"));

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

bool dbOk;
using (var scope = app.Services.CreateScope())
{
    dbOk = scope.ServiceProvider.GetService<CheckDatabaseService>().CheckDatabaseVersion();
    if(!dbOk)
        throw new Exception("Database version is not supported");
}

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    Authorization = new[] { new HangfireAuthorizationFilter() }
});

//using (var scope = app.Services.CreateScope())
//{
//    var erpUserService = scope.ServiceProvider.GetService<IIntegrationErpUserService>();
//    await erpUserService.LoginToIntegrationUser();
//}
try
{
    app.Run();
}
catch (Exception ex)
{
    var fileLogger = new NReco.Logging.File.FileLogger("UnHandledExceptions",new NReco.Logging.File.FileLoggerProvider("UnHandledExceptions.log", true));
    fileLogger.LogError(ex,ex.Message);
}