using AutoMapper;
using ERP.Domain.Entity;
using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ERP_Integration.Domain.Model.Integration.LoadUnLoadModel;

namespace ERP_Integration.Domain.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            Configure();
        }

        private void Configure()
        {
            CreateMap<OrderRequestSales, Transaction>()
                .ForMember(s => s.Id, opt => opt.Ignore())
                .ForMember(s => s.ClientTransactionId, b => b.MapFrom(a => a.Id))
                .ForMember(s => s.ClientTransactionNo, b => b.MapFrom(a => a.Id))
                .ForMember(s => s.TransactionDetails, c => c.MapFrom(m => m.SalesOrderRequestDetails))
                .ReverseMap();

            CreateMap<OrderRequestDetailSales, TransactionDetail>()
                .ForMember(s => s.Id, opt => opt.Ignore())
                .ForMember(s => s.ClientTransactionDetailId, b => b.MapFrom(a => a.Id))
                .ForMember(s => s.ItemCode, b => b.MapFrom(a => a.ItemSales != null ? a.ItemSales.ItemNumber : null))
                .ForMember(s => s.ItemName, b => b.MapFrom(a => a.ItemSales != null ? a.ItemSales.ItemNameAr : null))
                .ForMember(s => s.ItemSize, b => b.MapFrom(a => "1"))//defualt value
                .ForMember(s => s.BasePricePerUnit, b => b.MapFrom(a => a.BasePricePerUnit == 0 && a.Quantity.HasValue ? (a.TotalPriceBeforeTax.GetValueOrDefault()/ a.Quantity.GetValueOrDefault()) : a.BasePricePerUnit))
                .ReverseMap();

            CreateMap<Transaction, TransactionViewModel>();

            CreateMap<EmployeeLoadItemsRequestsDetails, LoadUnLoadItemDetail>()
                .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.Item.ItemNameAr));

            CreateMap<LoadUnLoadItemDetail, EmployeeLoadItemsRequestsDetails>()
                .ForMember(dest => dest.UserId,opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeId, opt => opt.Ignore())
                .ForMember(dest => dest.StoreId, opt => opt.Ignore())
                .ForMember(dest => dest.SalesmanStoreId, opt => opt.Ignore())
                .ForMember(dest => dest.LoadRequestId, opt => opt.Ignore())
                .ForMember(dest => dest.RequestStatus, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt,opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt,opt => opt.Ignore());

            CreateMap<EmployeeLoadItemsRequests, LoadUnLoadModel>()
                .ForMember(dest => dest.type, opt => opt.MapFrom(src => LoadUnLoadType.Load))
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.EmployeeNameAr))
                .ForMember(dest => dest.ItemDetails, opt => opt.MapFrom(src => src.EmployeeLoadItemsRequestsDetails));
            //CreateMap<LoadUnLoadModel, EmployeeLoadItemsRequests>()
            //    .ForMember(dest => dest.EmployeeLoadItemsRequestsDetails, opt => opt.MapFrom(src => src.ItemDetails))
            //    .AfterMap((src, dest) =>
            //    {
            //        foreach (var itemDetail in dest.EmployeeLoadItemsRequestsDetails)
            //        {
            //            itemDetail.UserId = src.UserId;
            //            itemDetail.EmployeeId = src.EmployeeId;
            //            itemDetail.StoreId = src.StoreId;
            //            itemDetail.SalesmanStoreId = src.SalesmanStoreId;
            //            itemDetail.LoadRequestId = src.Id;
            //            itemDetail.RequestStatus = src.RequestStatus;
            //            itemDetail.CreatedAt = src.CreatedAt;
            //            itemDetail.UpdatedAt  = src.UpdatedAt;
            //        }
            //    });

            CreateMap<Transaction, TransactionItemViewModel>()
                .ForMember(s => s.TransactionDetails, c => c.MapFrom(m => m.TransactionDetails));

            CreateMap<TransactionDetail, TransactionDetailsViewModel>();

            CreateMap<PaymentSales, Payment>()
                .ForMember(s => s.Id, opt => opt.Ignore())
                .ForMember(s => s.SalesPaymentId, b => b.MapFrom(a => a.Id))
                .ReverseMap();

            CreateMap<Payment, PaymentViewModel>();

            CreateMap<Customer, CustomerIntegration>();
            CreateMap<SalesPerson, SalespersonIntegration>();

            CreateMap<OrderRequestDetailSales, InvoiceModelDetail>()
                .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.ItemSales != null ? src.ItemSales.ItemNameAr : ""));
            CreateMap<OrderRequestSales, InvoiceModel>()
                .ForMember(dest => dest.InvoiceDetails, opt => opt.MapFrom(src => src.SalesOrderRequestDetails));
            CreateMap<InvoiceModel, InvoiceViewModel>();

        }
    }
}
