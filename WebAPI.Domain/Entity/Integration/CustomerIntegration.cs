using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    [Table("Customer")]
    public class CustomerIntegration
    {
        [Key]
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public int? Number { get; set; }
        public Guid AccGUID { get; set; }
        public string? Name { get; set; }
        public string? LatinName { get; set; }
        public string? Country { get; set; }
        public string? Area { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? Phone1 { get; set; }
        public string? phone2 { get; set; }
        public string? Email { get; set; }
        public double? PositionX { get; set; }
        public double? PositionY { get; set; }
        public bool IsStoped { get; set; }
        public Guid? SalespersonGUID { get; set; }
        public string? ErpCRUD_Type { get; set; }
        public DateTime? CeatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsSubmitted { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int? NoOfAttempts { get; set; }
        
    }
}
