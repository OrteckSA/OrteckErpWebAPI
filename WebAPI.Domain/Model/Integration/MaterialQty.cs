using ERP.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class MaterialQty
    {
        public Material Material { get; set; }
        public double Qty { get; set; }
        public Guid Store { get; set; }
        public Guid Customer { get; set; }
    }
}
