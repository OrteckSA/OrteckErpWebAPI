using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Qutation
{
    [Table("ITEM_PRICES")]
    public class ItemPrices
    {
        [Key]
        public int ITEM_NO { get; set; }
        public string? ITEM_NAME { get; set; }
        public string? ITEM_NAME2 { get; set; }
        public string? ITEM_CODE { get; set; }
        public string? ITEM_SIZE_X { get; set; }
        public string? ITEM_SIZE_Y { get; set; }
        public string? ITEM_MEASURMENT { get; set; }
    }
}
