using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("item_unit_conversions")]
    public class ItemUnitConversion : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
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
        [Column("item_id")]
        public int ItemId { get; set; }

        [Required]
        [Column("unit_type_id")]
        public int UnitTypeId { get; set; }

        [NotMapped]
        public int NoOfPiece
        {
            get
            {
                return int.Parse(NoOfPieceString);
            }
            set
            {
                NoOfPieceString = value.ToString();
            }
        }

        [Required]
        [Column("no_of_piece", TypeName = "varchar(255)")]
        public string NoOfPieceString { get; set; } = "1";
        [NotMapped]
        public bool IsDefaultUnit
        {
            get
            {
                return DefaultValue.Equals("yes",StringComparison.OrdinalIgnoreCase);
            }
            set
            {
                DefaultValue = value ? "yes" : "no";
            }
        }

        [Required]
        [Column("default_value", TypeName = "enum('yes','no')")]
        public string DefaultValue { get; set; } = "no";

        //[Required]
        //[Column("created_at", TypeName = "datetime")]
        //public DateTime CreatedAt { get; set; } = DateTime.Now;

        //[Required]
        //[Column("updated_at", TypeName = "datetime")]
        //public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
