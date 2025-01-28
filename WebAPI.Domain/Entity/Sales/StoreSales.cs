using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("stores")]
    public class StoreSales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("store_number")]
        public string? SoreNumber { get; set; }

        [Column("store_name_en")]
        public string? StoreNameEn { get; set; }

        [Column("store_name_ar")]
        public string? StoreNameAr { get; set; }

        [Column("reference")]
        public string? Reference { get; set; }

        [Column("note")]
        public string? Note { get; set; }

        [Column("status")]
        public string? Status { get; set; }
    }
}
