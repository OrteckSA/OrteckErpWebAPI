using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Sales
{
    public class SalesOrderRequestsModel: BaseModel
    {

        public int UserId { get; set; }
        public int? RequestLevel { get; set; }
        public int? NoOfItems { get; set; }
        public double? TotalTax { get; set; }
        public double? TotalDiscount { get; set; }
        public double TotalPrice { get; set; }

    }
}
