using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("banks")]
    public class BankSales : BaseSalesEntity,IUserIdEntity,ICreatedAtEntity,IUpdatedAtEntity
    {
        //[Column("id")]
        //public int Id { get; set; }

        [Column("bank_name_en")]
        public string BankNameEn { get; set; }

        [Column("bank_name_ar")]
        public string BankNameAr { get; set; }

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
