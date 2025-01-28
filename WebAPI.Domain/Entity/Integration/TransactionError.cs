using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    public class TransactionError:BaseEntity
    {
        [Column(nameof(TransactionId))]
        public long TransactionId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
