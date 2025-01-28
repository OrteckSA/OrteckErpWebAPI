using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    public class PaymentError : BaseEntity
    {
        public int PaymentId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
