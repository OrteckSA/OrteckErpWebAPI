using ERP_Integration.Domain.Entity.Sales;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Integration.Domain.Entity.Qutation
{
    public class BaseInvoiceDetails
    {
        [Key]
        public Guid DID { get; set; }
        public Guid? QMAINID { get; set; }
        public string? ITEM_CODE { get; set; }
        public string? ITEM_NAME { get; set; }
        public string? Item_Color { get; set; }
        public double? QTY { get; set; }
        public double? UNITPRICE { get; set; }
        public double? NETTOTal { get; set; }
        public double? Item_discountP { get; set; }
        public double Item_discountV { get; set; }

    }

    [Table("QUTATIONS_INVOICET_DTL")]
    public class InvoiceTradingDetails : BaseInvoiceDetails
    {

        //[ForeignKey("QUTATIONS_INVOICEH")]
        public string ITEM_SIZE { get; set; }
        public string ITEM_UNIT { get; set; }

        public InvoiceHeader? InvoiceHeader { get; set; }
    }
}
