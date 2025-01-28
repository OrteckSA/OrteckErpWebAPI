using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    [Table("Salesperson")]
    public class SalespersonIntegration
    {
        [Key]
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? LatinName { get; set; }
        public bool IsStoped { get; set; }
        public string? ErpCRUD_Type { get; set; }
        public DateTime? CeatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsSubmitted { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int? NoOfAttempts { get; set; }
        
    }
}
