using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("states")]
    public class StateSales:BaseSalesEntity
    {

        [Column("name")]
        public string? Name { get; set; }

        [Column("country_id")]
        public int CountryId { get; set; }

        [Column("status")]
        public string? Status { get; set; }
       
    }
}
