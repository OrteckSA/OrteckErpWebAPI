using Hangfire.Dashboard;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Razor;

namespace ERP.WebAPI.Filters
{
    public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public HangfireAuthorizationFilter()
        {
        }
        public bool Authorize(DashboardContext context)
        {
            return true;
        }

    }
}
