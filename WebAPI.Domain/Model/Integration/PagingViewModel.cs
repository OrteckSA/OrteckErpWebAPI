using ERP_Integration.Domain.Entity.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public class ViewModel
    {
        public GeneralTransaction Transaction { get; set; }
        public object Item { get; set; }
    }
    public class PagingViewModel
    {
        public List<ViewModel> Items = new List<ViewModel>();
        public int TotalCount;
    }
}
