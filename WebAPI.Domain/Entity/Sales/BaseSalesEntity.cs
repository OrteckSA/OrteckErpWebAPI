using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    public class BaseSalesEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
    public interface ICreatedAtEntity
    {
        DateTime CreatedAt { get; set; }
    }
    public interface IUpdatedAtEntity
    {
        DateTime UpdatedAt { get; set; }
    }
    public interface IUserIdEntity
    {
        public int UserId { get; set; }
    }
    public interface IIdEntity
    {
        public int Id { get; set; }
    }
}
