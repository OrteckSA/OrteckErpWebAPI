using ERP_Integration.Domain.Entity.Qutation;
using Microsoft.EntityFrameworkCore;

namespace ERP_Integration.Repository.Context
{
    public class QutationContext : BaseEFCoreContext
    {
        public QutationContext(DbContextOptions<QutationContext> options) : base(options)
        {
        }

        public DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public DbSet<InvoiceTradingDetails> InvoiceTradingDetails { get; set; }
        public DbSet<InvoiceTradingApprovedDetails> InvoiceTradingApprovedDetails { get; set; }
        public DbSet<ItemTrading> ItemTrading { get; set; }
        public DbSet<ItemPrices> ItemPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
               .Entity<InvoiceHeader>()
               .Property(d => d.QID)
               .ValueGeneratedNever();

            modelBuilder
                .Entity<InvoiceTradingDetails>()
                .Property(d => d.DID)
                .ValueGeneratedNever();

            modelBuilder
                .Entity<InvoiceTradingApprovedDetails>()
                .Property(d => d.DID)
                .ValueGeneratedNever();

            modelBuilder
                .Entity<ItemTrading>()
                .Property(d => d.ITEM_NO)
                .ValueGeneratedNever();

            modelBuilder.Entity<InvoiceTradingDetails>()
                .HasOne(x => x.InvoiceHeader)
                .WithMany(x => x.InvoiceTradingDetails)
                .HasForeignKey(x => x.QMAINID)
                .IsRequired(false);

            modelBuilder.Entity<InvoiceTradingApprovedDetails>()
                .HasOne(x => x.InvoiceHeader)
                .WithMany(x => x.InvoiceTradingApprovedDetails)
                .HasForeignKey(x => x.QMAINID)
                .IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(18, 5);
        }

        public override void SetValuesOnAdd<IEntity>(IEntity entity)
        {
        }
        public override void SetValuesOnDelete<IEntity>(IEntity entity)
        {
        }
        public override void SetValuesOnGet<IEntity>(IEntity entity)
        {
        }
        public override void SetValuesOnUpdate<IEntity>(IEntity entity)
        {
        }
    }
}