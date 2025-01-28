using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Model.Integration
{

    public class LoadUnLoadItemDetailOld
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemName{ get; set; }
        public int MeasurementUnitId { get; set; }
        public double Quantity { get; set; }
        public string? Reference { get; set; }
    }
    public class ItemDetailBase
    {
        public string Id { get; set; } = "";
        public string ItemId { get; set; } = "";
        public string ItemName { get; set; } = "";
        public string BatchCode { get; set; } = "";
        public double Quantity { get; set; }
        public int Unit { get; set; } = 1;
        public string UnitName { get; set; } = "";
        public string CategoryId { get; set; } = "";
        public string Data { get; set; } = "";
        public string Reference { get; set; } = "";
    }
    public class LoadUnLoadItemDetail : ItemDetailBase
    {
    }
    public enum LoadUnLoadType
    {
        Load, UnLoad
    }
    public class LoadUnLoadModelOld
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = "";
        public int SupervisorId { get; set; }
        public int SalesmanagerId { get; set; }
        public int StoreId { get; set; }
        public int SalesmanStoreId { get; set; }
        public int RequestLevel { get; set; }
        public int NoOfItems { get; set; }
        public LoadUnLoadType type { get; set; }
        public string? SupervisorNote { get; set; }
        public string? SalesmanagerNote { get; set; }
        public string? SupervisorStatus { get; set; }
        public string? SalesmanagerStatus { get; set; }
        public string? RequestStatus { get; set; }
        public string? Reference { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<LoadUnLoadItemDetail> ItemDetails { get; set; } = new List<LoadUnLoadItemDetail>();
    }
    public class LoadUnLoadModel
    {
        public string Id { get; set; }
        public string UserId { get; set; } = "";
        public string EmployeeId { get; set; } = "";
        public string EmployeeName { get; set; } = "";
        public string SupervisorId { get; set; } = "";
        public string SalesmanagerId { get; set; } = "";
        public string StoreId { get; set; } = "";
        public string SalesmanStoreId { get; set; } = "";
        public LoadUnLoadType type { get; set; }
        public string SupervisorNote { get; set; } = "";
        public string SalesmanagerNote { get; set; } = "";
        public string SupervisorStatus { get; set; } = "";
        public string SalesmanagerStatus { get; set; } = "";
        public string RequestStatus { get; set; } = "";
        public string Reference { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<LoadUnLoadItemDetail> ItemDetails { get; set; } = new List<LoadUnLoadItemDetail>();
    }
}
