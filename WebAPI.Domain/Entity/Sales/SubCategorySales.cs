using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("sub_categories")]
    public class SubCategorySales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("category_id")]
        public int? CategoryId { get; set; }

        [Column("sub_category_name_en")]
        public string? NameEn { get; set; }

        [Column("sub_category_name_ar")]
        public string? NameAr { get; set; }

        [Column("status")]
        public string? Status { get; set; } = "active";
        [Column("reference")]
        public string? Reference { get; set; }
    }
}
