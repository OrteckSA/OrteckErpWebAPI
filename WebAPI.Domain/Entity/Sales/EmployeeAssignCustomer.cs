using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("employee_assign_customers")]
    public class EmployeeAssignCustomer : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        //[Column("id")]
        //public int Id { get; set; }
        //[Column("user_id")]
        //public int? UserId { get; set; }

        [Column("employee_id")]
        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { get; set; }

        [Column("customer_id")]
        [ForeignKey(nameof(Customer))]
        public int? CustomerId { get; set; }

        [Column("user_type")]
        public int? UserTypeId { get; set; }

        //[Column("created_at")]
        //public DateTime? CreatedAt { get; set; }

        public EmployeeSales? Employee { get; set; }

        public CustomerSales? Customer { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }
    }
}
