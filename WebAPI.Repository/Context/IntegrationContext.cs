using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Entity.Sales;
using Microsoft.EntityFrameworkCore;

namespace ERP_Integration.Repository.Context
{
    public class IntegrationContext : BaseEFCoreContext
    {
        public IntegrationContext(DbContextOptions<IntegrationContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionDetail> TransactionDetail { get; set; }
        public DbSet<TransactionError> TransactionError { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentError> PaymentError { get; set; }
        public DbSet<RequestTypeMap> RequestTypeMap { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<BanksMap> BanksMap { get; set; }
        public DbSet<CustomerIntegration> Customer { get; set; }
        public DbSet<SalespersonIntegration> SalespersonIntegration { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<GeneralTransaction> GeneralTransaction { get; set; }

        public override void SetValuesOnAdd<IEntity>(IEntity entity)
        {
            if(entity is IUpdatedAtEntity updatedAtEntity)
                updatedAtEntity.UpdatedAt = DateTime.Now;
            if (entity is ICreatedAtEntity createdAtEntity)
                createdAtEntity.CreatedAt = DateTime.Now;
            //if(entity is IIdEntity idEntity)
            //{
            //    int newId = Set<IEntity>().MaxAsync();
            //}
        }
        public override void SetValuesOnDelete<IEntity>(IEntity entity)
        {
        }
        public override void SetValuesOnGet<IEntity>(IEntity entity)
        {
        }
        public override void SetValuesOnUpdate<IEntity>(IEntity entity)
        {
            if (entity is IUpdatedAtEntity updatedAtEntity)
                updatedAtEntity.UpdatedAt = DateTime.Now;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
               .Entity<Transaction>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<TransactionDetail>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();
            modelBuilder
                .Entity<TransactionError>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<Payment>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<PaymentError>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<RequestTypeMap>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<Setting>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<BanksMap>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<CustomerIntegration>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
              .Entity<SalespersonIntegration>()
              .Property(d => d.Id)
              .ValueGeneratedOnAdd();

            modelBuilder
              .Entity<States>()
              .Property(d => d.Id)
              .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<Transaction>()
                .HasMany(t => t.TransactionErrors)
                .WithOne(e => e.Transaction)
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Transaction>()
                .HasMany(t => t.TransactionDetails)
                .WithOne(d => d.Transaction)
                .HasForeignKey(t => t.TransactionId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(18, 5);
        }

        //[DbFunction("JSON_VALUE", IsBuiltIn = true, IsNullable = false)]
        //public static string JsonValue(string expression, string path) => throw new NotImplementedException();
    }
}