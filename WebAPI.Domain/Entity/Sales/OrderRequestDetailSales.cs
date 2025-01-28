using ERP_Integration.Domain.Enums.Sales;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("sales_order_request_details")]
    public class OrderRequestDetailSales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("sales_order_request_id")]
        [ForeignKey(nameof(OrderRequestSales))]
        public int OrderRequestSalesId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [ForeignKey(nameof(ItemSales))]
        [Column("item_id")]
        public int ItemId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("measurement_unit_id")]
        public int MeasurementUnitId { get; set; }

        [Column("base_price_per_unit")]
        public decimal BasePricePerUnit { get; set; }

        [Column("bonus")]
        public decimal? Bonus { get; set; }

        [Column("quantity")]
        public decimal? Quantity { get; set; }

        [Column("total_price")]
        public decimal? TotalPrice { get; set; }

        [Column("total_tax")]
        public double? TotalTax { get; set; }

        [Column("tax_type")]
        public string? TaxType { get; set; }

        [Column("total_price_before_tax")]
        public decimal? TotalPriceBeforeTax { get; set; }

        [Column("total_price_with_tax")]
        public decimal? TotalPriceWithTax { get; set; }

        [Column("request_status")]
        public string? RequestStatus { get; set; }

        [Column("Item_Discount")]
        public double? ItemDiscount { get; set; }

        public  OrderRequestSales OrderRequestSales { get; set; }
        public ItemSales ItemSales { get; set; }
    }
}
