using ERP_Integration.Domain.Enums.Sales;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("sales_order_requests")]
    public class OrderRequestSales
         : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        public OrderRequestSales()
        {
            this.SalesOrderRequestDetails = new List<OrderRequestDetailSales>();
        }
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("request_level")]
        public int? RequestLevel { get; set; }

        [Column("request_type")]
        public string? RequestType { get; set; }

        [Column("employee_id")]
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }

        [Column("customer_id")]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Column("store_id")]
        [ForeignKey(nameof(StoreSales))]
        public int StoreId { get; set; }

        [Column("supervisor_id")]
        public int SupervisorId { get; set; }

        [Column("salesmanager_id")]
        public int? SalesManagerId { get; set; }

        [Column("no_of_items")]
        public string? NoOfItems { get; set; }

        [Column("supervisor_note")]
        public string? SupervisorNote { get; set; }

        [Column("salesmanager_note")]
        public string? SalesManagerNote { get; set; }

        [Column("total_price_without_tax_discount")]
        public double? TotalPriceWithoutTaxDiscount { get; set; }

        [Column("total_tax")]
        public double? TotalTax { get; set; }

        [Column("total_discount")]
        public double? TotalDiscount { get; set; }

        [Column("total_price")]
        public double TotalPrice { get; set; }

        [Column("request_status")]
        public string? RequestStatus { get; set; }


        [Column("salesmanager_status")]
        public string? SalesManagerStatus { get; set; }

        [Column("supervisor_status")]
        public string? SupervisorStatus { get; set; }

        [Column("is_successfully_submitted")]
        public bool IsSuccessfullySubmitted { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("no_invoice")]
        public string? NoInvoice { get; set; }
        public List<OrderRequestDetailSales> SalesOrderRequestDetails { get; set; }

        public EmployeeSales Employee { get; set; }

        public CustomerSales Customer { get; set; }

        public StoreSales StoreSales { get; set; }
    }
}
