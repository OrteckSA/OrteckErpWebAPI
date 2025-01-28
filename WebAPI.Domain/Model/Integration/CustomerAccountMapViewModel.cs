using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class CustomerAccountMapViewModel : BaseModel
    {
        public string? CustomerNameAr { get; set; }
        public string? CustomerNameEn { get; set; }
        public Guid? AccountGUID { get; set; }
        public string? AccountName { get; set; }
        public string? AccountCode { get; set; }
    }
}
