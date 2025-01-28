using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Enums.Sales;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    public class Transaction : BaseEntity
    {
        public string? ClientTransactionId { get; set; }
        public int? ClientTransactionNo { get; set; }
        public int? UserId { get; set; }

        public int? RequestLevel { get; set; }

        public string? RequestType { get; set; }

        public string? EmployeeId { get; set; }
        public string? EmployeeNameAr { get; set; }
        public string? EmployeeNameEn { get; set; }

        public string? CustomerId { get; set; }
        public string? CustomerNameAr { get; set; }
        public string? CustomerNameEn { get; set; }

        public string? StoreId { get; set; }

        public int? SupervisorId { get; set; }

        public int? SalesManagerId { get; set; }

        public string? NoOfItems { get; set; }

        public string? SupervisorNote { get; set; }

        public string? SalesManagerNote { get; set; }

        public decimal? TotalPriceWithoutTaxDiscount { get; set; }

        public decimal? TotalTax { get; set; }

        public decimal? TotalDiscount { get; set; }

        public decimal? TotalPrice { get; set; }

        public string? RequestStatus { get; set; }

        public string? SalesManagerStatus { get; set; }

        public string? SupervisorStatus { get; set; }

        public DateTime? CeatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? NoInvoice { get; set; }

        public DateTime? InsertedDate { get; set; }
        public bool IsSubmittedToErp { get; set; }
        public string SubmittedToErpStatus { get; set; }
        public DateTime? SubmittedToErpDate { get; set; }
        public Guid? SubmittedToErpUserId { get; set; }
        public int? NoOfAttempts { get; set; }
        public Guid? ErpBillGuid { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
        public List<TransactionError> TransactionErrors { get; set; } = new List<TransactionError>();


    }
}
