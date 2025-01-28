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
    [Table("employee_load_items_requests")]
    public class EmployeeLoadItemsRequests : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        public EmployeeLoadItemsRequests()
        {
            EmployeeLoadItemsRequestsDetails = new List<EmployeeLoadItemsRequestsDetails>();
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

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("supervisor_id")]
        public int? SupervisorId { get; set; }

        [Column("salesmanager_id")]
        public int? SalesmanagerId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("salesman_store_id")]
        public int SalesmanStoreId { get; set; }

        [Column("no_of_items")]
        public int NoOfItems { get; set; }

        [Column("supervisor_note")]
        public string? SupervisorNote { get; set; }

        [Column("salesmanager_note")]
        public string? SalesmanagerNote { get; set; }

        [Column("supervisor_status")]
        public string? SupervisorStatus { get; set; }

        [Column("salesmanager_status")]
        public string? SalesmanagerStatus { get; set; }

        [Column("request_status")]
        public string? RequestStatus { get; set; }

        [Column("reference")]
        public string? Reference { get; set; }
        public List<EmployeeLoadItemsRequestsDetails> EmployeeLoadItemsRequestsDetails { get; set; }
        public EmployeeSales Employee { get; set; }

    }
}
