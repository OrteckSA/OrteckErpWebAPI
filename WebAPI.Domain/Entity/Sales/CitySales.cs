using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("cities")]
    public class CitySales:BaseSalesEntity
    {
        //[Column("id")]
        //public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("state_id")]
        public int StateId { get; set; }

        [Column("status")]
        public string? Status { get; set; }
    }
}
