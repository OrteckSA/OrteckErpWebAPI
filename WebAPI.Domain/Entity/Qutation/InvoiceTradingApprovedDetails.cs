using ERP_Integration.Domain.Entity.Sales;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Integration.Domain.Entity.Qutation
{
    [Table("QUTATIONS_INVOICE_DTL")]
    public class InvoiceTradingApprovedDetails : BaseInvoiceDetails
    {
        public int SERIAL { get; set; }
        public double? ITEM_SIZE_X { get; set; }
        public double? ITEM_SIZE_Y { get; set; }

        public string? ITEM_MEASURMENT { get; set; }
        //Item_Color
        public string? Item_Color { get; set; }


        public InvoiceHeader? InvoiceHeader { get; set; }
    }
}
