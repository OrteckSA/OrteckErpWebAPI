using ERP_Integration.Domain.Entity.Integration;
using ERP_Integration.Domain.Enums.Integration;
using ERP_Integration.Domain.Model.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface ITransactionService
    {
        Task<GeneralTransaction> CreateTransaction<T>(T item, int userId, TransactionType transactionType);
        Task Update(GeneralTransaction transaction);
        Task Error(GeneralTransaction transaction, Exception e);
        Task Submitted(GeneralTransaction transaction);
        Task Reject(GeneralTransaction transaction);
        Task<GeneralTransaction> CreateTransaction<T>(string itemId, T item, int userId, TransactionType transactionType);
    }
    public interface ITransactionManagementService
    {
        Task<PagingViewModel> GetLoadItemsViewModel(TransactionRequest statusId, string searchText, DateTime? fromDate, DateTime? toDate,TransactionType[] types, int pageSize, int skip);
        Task<PagingViewModel> GetLoadItemsViewModel(Func<IQueryable<GeneralTransaction>, IQueryable<GeneralTransaction>> queryOptions, int pageSize, int skip);
        Task<ResultViewModel> SubmitTransaction(int id);
        Task<ResultViewModel> DeleteTransaction(int id);
        Task<ResultViewModel> DeleteTransaction(int[] ids);
        Task<ResultViewModel> GetTransactionItem(int id);
        Task<ResultViewModel> GetTransactionItemViewModel(int id);
    }
}
