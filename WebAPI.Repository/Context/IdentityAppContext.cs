using ERP_Integration.Domain.Entity.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERP_Integration.Repository.Context
{
    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        private readonly DbContextOptions _options;

        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
