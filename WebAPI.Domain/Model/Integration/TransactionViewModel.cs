using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class TransactionViewModel : BaseModel
    {
        public string ClientTransactionNo { get; set; }
        public string? RequestType { get; set; }

        public string? EmployeeNameAr { get; set; }
        public string? EmployeeNameEn { get; set; }

        public string? CustomerNameAr { get; set; }
        public string? CustomerNameEn { get; set; }

        public string? NoOfItems { get; set; }
        public double? TotalPriceWithoutTaxDiscount { get; set; }

        public double? TotalTax { get; set; }

        public double? TotalDiscount { get; set; }

        public double TotalPrice { get; set; }

        public DateTime CeatedAt { get; set; }

        public string CeatedAtStr
        {
            get
            {
                return CeatedAt.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
        }

        public string? SubmittedToErpStatus { get; set; }
    }
}
