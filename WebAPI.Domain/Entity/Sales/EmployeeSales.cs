using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("employees")]
    public class EmployeeSales : BaseSalesEntity, ICreatedAtEntity, IUpdatedAtEntity, IUserIdEntity
    {
        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("ref_id")]
        public string? RefId { get; set; }

        [Column("employee_name_en")]
        public string? EmployeeNameEn { get; set; }

        [Column("employee_name_ar")]
        public string? EmployeeNameAr { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("type")]
        public int TypeId { get; set; }

        [Column("group_type")]
        public string? GroupTypeId { get; set; }

        //status
        [Column("status")]
        public string? Status { get; set; }

        public ICollection<EmployeeAssignCustomer> EmployeeAssignCustomers { get; set; }


    }
}
