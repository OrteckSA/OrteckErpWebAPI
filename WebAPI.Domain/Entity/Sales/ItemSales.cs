using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("items")]
    public class ItemSales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("item_name_en")]
        public string? ItemNameEn { get; set; }

        [Column("item_name_ar")]
        public string? ItemNameAr { get; set; }

        [Column("item_number")]
        public string? ItemNumber { get; set; }

        //category_id
        [Column("category_id")]
        public int? CategoryId { get; set; }

        [Column("sub_category_id")]
        public int? SubCategoryId { get; set; }

        //inventory_id
        [Column("inventory_id")]
        public int? InventoryId { get; set; }
        //selling_price
        [Column("selling_price")]
        public string? SellingPrice { get; set; }


        [Column("tax")]
        public string? Tax { get; set; }
        //status
        [Column("status")]
        public string? Status { get; set; }
        [Column("stock_status")]
        public string? StockStatus { get; set; }
        //TaxStatus
        [Column("tax_status")]
        public string? TaxStatus { get; set; }
        [Column("tax_type")]
        public string? TaxType { get; set; }
        //created_at
        //[Column("created_at")]
        //public DateTime? CreatedAt { get; set; }
        ////updated_at
        //[Column("updated_at")]
        //public DateTime? UpdatedAt { get; set; }
        [Column("reference")]
        public string? Reference { get; set; }
        
    }
}
