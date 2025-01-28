using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("inventory_types")]
    public class InventoryTypeSale : BaseSalesEntity, IUserIdEntity, ICreatedAtEntity, IUpdatedAtEntity
    {
        [Column("updated_at")]
        public DateTime UpdatedAt { get;set; }
        [Column("created_at")]
        public DateTime CreatedAt { get;set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("inventory_name_ar")]
        public string NameAr { get; set; }
        [Column("inventory_name_en")]
        public string NameEn { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
    public enum InventoryStatus
    {
        Active,
        Inactive
    }
}
