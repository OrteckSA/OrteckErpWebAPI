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
    public class Payment : BaseEntity
    {
        public Payment()
        {
        }

        public long SalesPaymentId { get; set; }

        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeNameAr { get; set; }
        public string? EmployeeNameEn { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerNameAr { get; set; }
        public string? CustomerNameEn { get; set; }
        public int? SupervisorId { get; set; }
        public int? SalesManagerId { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string? CustomerName { get; set; }
        public string? SalesmanName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PaymentNo { get; set; }
        public string? ReferenceNo { get; set; }
        public int? BankId { get; set; }
        public string? BankNameAr { get; set; }
        public string? BankNameEn { get; set; }
        public int? BranchId { get; set; }
        public string? DrawerName { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Note { get; set; }
        public string? RequestStatus { get; set; }
        public DateTime? RespondedDate { get; set; }
        public DateTime? CeatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CurrencyCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? SearialNo { get; set; }
        public DateTime InsertedDate { get; set; }
        public bool IsSubmittedToErp { get; set; }
        public string SubmittedToErpStatus { get; set; }
        public DateTime? SubmittedToErpDate { get; set; }
        public Guid? SubmittedToErpUserId { get; set; }
        public int? NoOfAttempts { get; set; }
        public Guid? ErpEntryGuid { get; set; }
    }
}
