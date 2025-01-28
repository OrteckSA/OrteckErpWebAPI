using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("customer_types")]
    public class CustomerTypeSales: BaseSalesEntity,ICreatedAtEntity, IUpdatedAtEntity,IUserIdEntity
    {
        [Column("customer_type_ar")]
        public string? NameAr { get; set; }
        [Column("customer_type_en")]
        public string? NameEn { get; set; }
        [Column("status")]
        public string status { get; set; } = "active";//inactive
        [Column("ref")]
        public string Ref { get; set; }

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
