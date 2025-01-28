using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Integration.Domain.Entity.Qutation
{
    [Table("ITEM_TRADING")]
    public class ItemTrading
    {
       
        [Key]
        public int ITEM_NO { get; set; }
        public string? ITEM_NAME { get; set; }
        public string? ITEM_CODE { get; set; }
        public string? ITEM_SIZE { get; set; }
        public string? ITEM_UNIT { get; set; }
    }
}
