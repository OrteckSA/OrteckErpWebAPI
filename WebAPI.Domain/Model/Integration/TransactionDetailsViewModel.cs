using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class TransactionDetailsViewModel : BaseModel
    {
        public long TransactionId { get; set; }
        public string? ClientTransactionDetailId { get; set; }

        public int? UserId { get; set; }

        public int? EmployeeId { get; set; }

        public int? StoreId { get; set; }

        public int? ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? ItemSize { get; set; }
        public int? CategoryId { get; set; }

        public int? MeasurementUnitId { get; set; }

        public decimal BasePricePerUnit { get; set; }

        public decimal? Bonus { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? TotalTax { get; set; }

        public string? TaxType { get; set; }

        public decimal? TotalPriceBeforeTax { get; set; }

        public decimal? TotalPriceWithTax { get; set; }

        public string? RequestStatus { get; set; }

        public DateTime? CeatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public float? ItemDiscount { get; set; }
    }
}
