using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("employee_load_items_request_details")]
    public class EmployeeLoadItemsRequestsDetails : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("salesman_store_id")]
        public int SalesmanStoreId { get; set; }

        [Column("item_id")]
        public int ItemId { get; set; }

        [Column("load_request_id")]
        //[ForeignKey(nameof(Request))]
        public int LoadRequestId { get; set; }

        [Column("measurement_unit_id")]
        public int MeasurementUnitId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
     
        [Column("request_status")]
        public string? RequestStatus { get; set; }

        [Column("reference")]
        public string? Reference { get; set; }
        public EmployeeLoadItemsRequests Request { get; set; }
        public ItemSales Item { get; set; }

    }
}
