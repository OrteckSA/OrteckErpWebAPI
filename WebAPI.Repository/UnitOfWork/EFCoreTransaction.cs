using Common.Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace ERP_Integration.Repository.UnitOfWork
{
    internal class EFCoreTransaction: ITransaction
    {
        private IDbContextTransaction _transaction;
        public EFCoreTransaction(IDbContextTransaction transaction)
        {
            _transaction = transaction;
        }
        public void Commit()
        {
            _transaction.Commit();
        }

        public async Task CommitAsync()
        {
            await _transaction.CommitAsync();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public async Task RollbackAsync()
        {
            await _transaction.RollbackAsync();
        }
    }
}
