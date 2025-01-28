using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    public class EmployeeAccountMap : BaseEntity
    {
        
        public int SalesEmployeeId { get; set; }
        public Guid ErpAccountGUID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
