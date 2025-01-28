using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("customer_payments")]
    public class PaymentSales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey(nameof(Employee))]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(Customer))]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("supervisor_id")]
        public int? SupervisorId { get; set; }

        [Column("salesmanager_id")]
        public int? SalesManagerId { get; set; }

        [Column("payment_type")]
        public string? PaymentType { get; set; }

        [Column("amount")]
        public double? Amount { get; set; }

        [Column("customer_name")]
        public string? CustomerName { get; set; }

        [Column("salesman_name")]
        public string? SalesmanName { get; set; }

        [Column("payment_date")]
        public DateTime? PaymentDate { get; set; }

        [Column("payment_no")]
        public string? PaymentNo { get; set; }

        [Column("reference_no")]
        public string? ReferenceNo { get; set; }

        [ForeignKey(nameof(Bank))]
        [Column("bank_id")]
        public int? BankId { get; set; }

        [Column("branch_id")]
        public int? BranchId { get; set; }

        [Column("drawer_name")]
        public string? DrawerName { get; set; }

        [Column("cheque_no")]
        public string? ChequeNo { get; set; }

        [Column("due_date")]
        public DateTime? DueDate { get; set; }

        [Column("note")]
        public string? Note { get; set; }

        [Column("request_status")]
        public string? RequestStatus { get; set; }

        [Column("responded_date")]
        public DateTime? RespondedDate { get; set; }

        [Column("currencycode")]
        public DateTime? CurrencyCode { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("searialno")]
        public string? SearialNo { get; set; }

        public EmployeeSales Employee { get; set; }
        public CustomerSales Customer { get; set; }
        public BankSales Bank { get; set; }
    }
}
