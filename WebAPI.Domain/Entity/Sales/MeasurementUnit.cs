using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("measurement_units")]
    public class MeasurementUnit : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("unit_name_en", TypeName = "varchar(255)")]
        public string UnitNameEn { get; set; }

        [Required]
        [Column("status", TypeName = "enum('active','inactive')")]
        public string Status { get; set; } = "active";

        //[Required]
        //[Column("created_at", TypeName = "datetime")]
        //public DateTime CreatedAt { get; set; } = DateTime.Now;

        //[Required]
        //[Column("updated_at", TypeName = "timestamp")]
        //public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
