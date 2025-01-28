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

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "ERP WebAPI V1");
        options.RoutePrefix = string.Empty; // To access Swagger at the root URL
    });
}

app.UseStaticFiles();

//app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

bool dbOk;
using (var scope = app.Services.CreateScope())
{
    dbOk = scope.ServiceProvider.GetService<CheckDatabaseService>().CheckDatabaseVersion();
    //if(!dbOk)
        //throw new Exception("Database version is not supported");
}

//app.UseHangfireDashboard("/hangfire", new DashboardOptions
//{
//    Authorization = new[] { new HangfireAuthorizationFilter() }
//});

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