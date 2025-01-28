using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("countries")]
    public class CountrySales:BaseSalesEntity
    {
        //[Column("id")]
        //public int Id { get; set; }

        [Column("sortname")]
        public string? ShortName { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("phonecode")]
        public int? PhoneCode { get; set; }

        [Column("currency")]
        public string? Currency { get; set; }

        [Column("currency_short")]
        public string? CurrencyShort { get; set; }

        [Column("status")]
        public string? Status { get; set; }
       
    }
}
