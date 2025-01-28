using ERP_Integration.Domain.Entity.Sales;
using Microsoft.EntityFrameworkCore;

namespace ERP_Integration.Repository.Context
{
    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SalesContext : BaseEFCoreContext
    {
        public SalesContext(DbContextOptions<SalesContext> options)
           : base(options)
        {
        }
        //public SalesContext(string constr) : base(new MySqlConnection(constr),true)
        ////public SalesContext(string constr) : base(constr)
        //{
        //}
        public DbSet<OrderRequestSales> SalesOrderRequest { get; set; }
        public DbSet<OrderRequestDetailSales> SalesOrderRequestDetails { get; set; }
        public DbSet<PaymentSales> SalesPayment { get; set; }
        public DbSet<StoreSales> SalesStore { get; set; }
        public DbSet<ItemSales> Item { get; set; }
        public DbSet<CustomerSales> CustomerSales { get; set; }
        public DbSet<CustomerTypeSales> CustomerTypeSales { get; set; }
        public DbSet<EmployeeSales> EmployeeSales { get; set; }
        public DbSet<EmployeeAssignCustomer> EmployeeAssignCustomers { get; set; }
        public DbSet<CountrySales> CountrySales { get; set; }
        public DbSet<StateSales> StatesSales { get; set; }
        public DbSet<CitySales> CitiesSales { get; set; }
        public DbSet<StockItemSales> StockItemsSales { get; set; }
        public DbSet<ItemUnitConversion> ItemUnitConversions{ get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits{ get; set; }
        public DbSet<CategorySales> CategorySales { get; set; }
        public DbSet<SubCategorySales> SubCategorySales { get; set; }
        public DbSet<EmployeeLoadItemsRequests> EmployeeLoadItemsRequests { get; set; }
        public DbSet<EmployeeLoadItemsRequestsDetails> EmployeeLoadItemsRequestsDetails { get; set; }
        public DbSet<InventoryTypeSale> InventoryTypeSales { get; set; }

        public override void SetValuesOnAdd<IEntity>(IEntity entity)
        {
            if (entity is ICreatedAtEntity createdAtEntity)
                createdAtEntity.CreatedAt = DateTime.Now;
            if(entity is IUpdatedAtEntity updatedAtEntity)
                updatedAtEntity.UpdatedAt = DateTime.Now;
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
               .Entity<CustomerSales>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<EmployeeSales>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<EmployeeAssignCustomer>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder
               .Entity<StockItemSales>()
               .Property(d => d.Id)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<EmployeeLoadItemsRequests>()
                .HasMany(e => e.EmployeeLoadItemsRequestsDetails)
                .WithOne(d => d.Request)
                .HasForeignKey(d => d.LoadRequestId);

            modelBuilder.Entity<EmployeeLoadItemsRequests>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(d => d.EmployeeId);

            modelBuilder.Entity<EmployeeLoadItemsRequestsDetails>()
                .HasOne(e => e.Item)
                .WithMany()
                .HasForeignKey(d => d.ItemId);

            modelBuilder.Entity<OrderRequestDetailSales>()
                .HasOne(e => e.ItemSales)
                .WithMany()
                .HasForeignKey(d => d.ItemId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(18, 5);
        }

    }
}