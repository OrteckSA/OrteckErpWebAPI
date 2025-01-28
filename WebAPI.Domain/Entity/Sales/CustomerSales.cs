using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Entity.Sales
{
    [Table("customers")]
    public class CustomerSales:BaseSalesEntity,ICreatedAtEntity,IUpdatedAtEntity,IUserIdEntity
    {
        [Column("app_employee_id")]
        public int? EmployeeId { get; set; }

        [Column("ref_id")]
        public string? RefId { get; set;}

        [Column("customer_id")]
        public string? CustomerId { get; set; }

        [Column("customer_name_en")]
        public string? CustomerNameEn { get; set; }

        [Column("customer_name_ar")]
        public string? CustomerNameAr { get; set; }

        [Column("customer_type_id")]
        public string? CustomerTypeId { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone_no")]
        public string? PhoneNo { get; set; }

        [Column("fax")]
        public string? Fax { get; set; }

        [Column("payment_type")]
        public string? PaymentType { get; set; }

        [Column("tax_status")]
        public string TaxStatus { get; set; } = "yes";

        [Column("state_id")]
        public string? StateId { get; set; }

        [Column("city_id")]
        public string? CityId { get; set; }

        [Column("area1")]
        public string? Area1 { get; set; }

        [Column("area2")]
        public string? Area2 { get; set; }
        [Column("location")]
        public string? Location { get; set; }
        [Column("latitude")]
        public string? Latitude { get; set; }

        [Column("longitude")]
        public string? Longitude { get; set; }
        [Column("credit_limit")]
        public string? CreditLimit { get; set; } = "9999";
        [Column("cheque_due_date")]
        public string? ChequeDueDate { get; set; } = "90";
        [Column("discount")]
        public float? Discount { get; set; } = 0;
        [Column("balance")]
        public string? Balance { get; set; } = "0";
        [Column("status")]
        public string? status { get; set; } = "active";//inactive

        [Required]
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Column("user_id")]
        public int UserId { get; set; }
    }
}
