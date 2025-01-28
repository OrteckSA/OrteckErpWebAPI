using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Enums.Integration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Integration
{
    //[Table("GeneralTransaction")]
    public class GeneralTransaction : IIdEntity, IUserIdEntity, ICreatedAtEntity, IUpdatedAtEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public TransactionType TransactionType { get; set; }
        [NotMapped]
        public string TransactionTypeName { get => TransactionType.ToString(); }
        public string TransactionData { get; set; } = "{}";
        public string ItemId { get; set; } = "";
        public int SubmittedBy { get; set; }
        public TransactionSubmitStatus SubmittedStatus { get; set; }
        [NotMapped]
        public string SubmittedStatusName { get => SubmittedStatus.ToString(); }
        public TransactionRequest RequestStatus { get; set; }
        [NotMapped]
        public string RequestStatusName { get => RequestStatus.ToString(); }
        public int NoOfAttempts { get; set; }
        public DateTime CreatedAt { get; set; }
        [NotMapped]
        public string CreatedAtText=> CreatedAt.ToString("dd/MM/yyyy hh:mm:ss tt");
        public DateTime UpdatedAt { get; set; }
        [NotMapped]
        public string UpdatedAtText => UpdatedAt.ToString("dd/MM/yyyy hh:mm:ss tt");
    }
}
