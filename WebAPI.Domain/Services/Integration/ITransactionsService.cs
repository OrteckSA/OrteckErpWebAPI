using ERP_Integration.Domain.Entity.Sales;
using ERP_Integration.Domain.Model.Integration;

namespace ERP_Integration.Domain.Services.Integration
{
    public interface IIntegrationTransactionService
    {
        Task SubmitIntegrationTransactionsToLocal();
        Task<TransactionPagingViewModel> GetTransactionsViewModel(int statusId,string searchText,DateTime? fromDate, DateTime? toDate, int pageSize, int skip);
        Task<TransactionItemViewModel> GetTransactionItemViewModelById(int id);
        Task DeleteTransaction(int id);
        Task<ResultViewModel> UpdateTransactions(int transactionId);
    }
}
