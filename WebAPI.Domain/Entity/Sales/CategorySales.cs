using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("categories")]
    public class CategorySales:BaseSalesEntity,IUserIdEntity,ICreatedAtEntity,IUpdatedAtEntity
    {
        //[Column("id")]
        //public int Id { get; set; }

        //[Column("user_id")]
        //public int? UserId { get; set; }

        [Column("category_name_en")]
        public string? NameEn { get; set; }

        [Column("category_name_ar")]
        public string? NameAr { get; set; }

        [Column("status")]
        public string? Status { get; set; } = "active";//inactive

        //[Column("created_at")]
        //public DateTime? CreatedAt { get; set; }

        //[Column("updated_at")]
        //public DateTime? UpdatedAt { get; set; }

        [Column("reference")]
        public string? Reference { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }
    }
}
