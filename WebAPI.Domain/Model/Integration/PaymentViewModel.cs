using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class PaymentViewModel : BaseModel
    {

        public string? EmployeeNameAr { get; set; }
        public string? EmployeeNameEn { get; set; }

        public string? CustomerNameAr { get; set; }
        public string? CustomerNameEn { get; set; }

        public string? PaymentType { get; set; }
        
        public decimal Amount { get; set; }

        public string? BankNameAr { get; set; }
        public string? BankNameEn { get; set; }

        public string? PaymentNo { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string PaymentDateStr
        {
            get
            {
                return PaymentDate.GetValueOrDefault().ToString("dd/MM/yyyy hh:mm:ss tt");
            }
        }

        public string? SubmittedToErpStatus { get; set; }
    }
}
