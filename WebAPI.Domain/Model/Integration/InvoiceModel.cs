using ERP_Integration.Domain.Entity.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{
    public enum InvoiceType
    {
        Invoice, ReturnInvoice
    }
    public class InvoiceModel
    {
        public string Id { get; set; } = "";
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string StoreName { get; set; } = "";
        public string SupervisorId { get; set; } = "";
        public string StoreId { get; set; } = "";
        public string SalesmanStoreId { get; set; } = "";
        public string CustomerId { get; set; } = "";
        public string? SalesManagerId { get; set; } = "";
        public int RequestLevel { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Notes { get; set; }
        public InvoiceType type { get; set; }
        public string TaxType { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<InvoiceModelDetail> InvoiceDetails { get; set; }=new List<InvoiceModelDetail>();
    }
    public class InvoiceModelOld
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public int SupervisorId { get; set; }
        public int StoreId { get; set; }
        public int SalesmanStoreId { get; set; }
        public int CustomerId { get; set; }
        public int? SalesManagerId { get; set; }
        public int RequestLevel { get; set; }
        public string? NoInvoice { get; set; }
        public InvoiceType type { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<InvoiceModelDetail> InvoiceDetails { get; set; }=new List<InvoiceModelDetail>();
    }
    public class InvoiceViewModel
    {
        public string Id { get; set; }
        public string EmployeeName { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string StoreName { get; set; } = "";
        public double NoOfItems { get; set; }
        public double Price { get; set; }
        public double Tax{ get; set; }
        public double TotalDiscount{ get; set; }
        public double Total{ get; set; }
        public double TotalPriceWithTaxDiscount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<InvoiceModelDetail> InvoiceDetails { get; set; }=new List<InvoiceModelDetail>();
    }
    public class InvoiceModelDetailOld
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int MeasurementUnitId { get; set; }
        public double BasePricePerUnit { get; set; }
        public double Bonus { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double TotalTax { get; set; }
        public string TaxType { get; set; } = "";
        public double ItemDiscount { get; set; }
        public double TotalPriceBeforeTax { get; set; }
        public double TotalPriceWithTax { get; set; }
    }
    public class InvoiceModelDetail: ItemDetailBase
    {
        public double BasePricePerUnit { get; set; }
        public double Bonus { get; set; }
        public double TotalPrice { get; set; }
        public double TotalTax { get; set; }
        public double ItemDiscount { get; set; }
        public double TotalPriceBeforeTax { get; set; }
        public double TotalPriceWithTax { get; set; }
    }
}
