using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    public class RequestTypeMap : BaseEntity
    {
        public string RequestTypeName { get; set; }
        public Guid ErpBillTypeGuid { get; set; }
        public int? ErpBillTypeId { get; set; }
    }
}
