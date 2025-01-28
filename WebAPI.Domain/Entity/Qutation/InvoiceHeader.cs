using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Integration.Domain.Entity.Qutation
{
    [Table("QUTATIONS_INVOICEH_VIEW")]
    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            this.InvoiceTradingDetails = new Collection<InvoiceTradingDetails>();
            this.InvoiceTradingApprovedDetails = new Collection<InvoiceTradingApprovedDetails>();
        }
        [Key]
        public Guid QID { get; set; }
        public int? QSTATUS { get; set; }
        public long? QQSERIAL { get; set; }
        public long? QINVOICESERIAL { get; set; }
        public string? CUSTOMERSERIAL { get; set; }
        public string? TERMSCONDTIONS { get; set; }
        public double? SALESTAX { get; set; }
        public int? SALESTAXP { get; set; }
        public double? NETPRICE { get; set; }
        public double? TOTALPRICE { get; set; }
        public double? DISCOUNT { get; set; }
        public int? SALES_ORDER_SER { get; set; }
        public string? CUSTOMER_INV { get; set; }
        public bool TaxAttachmentIsNull { get; set; }
        public int? POSTED { get; set; }
        public string? STORE { get; set; }
        public string? NOTE { get; set; }
        public ICollection<InvoiceTradingDetails> InvoiceTradingDetails { get; set; }
        public ICollection<InvoiceTradingApprovedDetails> InvoiceTradingApprovedDetails { get; set; }
        public DateTime CREATEDATE { get; set; }
    }
}
