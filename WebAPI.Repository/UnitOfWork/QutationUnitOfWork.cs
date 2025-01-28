using Common.Domain;
using ERP.Repository.UnitOfWork;
using ERP_Integration.Domain.UnitOfWork;
using ERP_Integration.Repository.Context;

namespace ERP_Integration.Repository.UnitOfWork
{
    public class QutationUnitOfWork : UnitOfWorkBase, IQutationUnitOfWork
    {
        //public QutationUnitOfWork(string connectionString) : base(connectionString)
        //{
        //}

        /*
private bool disposed = false;
private readonly QutationContext _context;

private IGenericRepository<InvoiceHeader> _invoiceHeaderRepository;
private IGenericRepository<ItemTrading> _itemTradingRepository;

public QutationUnitOfWork(QutationContext context)
{
   _context = context;
}

public IGenericRepository<InvoiceHeader> InvoiceHeaderRepository { get => _invoiceHeaderRepository ?? (_invoiceHeaderRepository = new QutationGenericRepository<InvoiceHeader>(_context)); }
public IGenericRepository<ItemTrading> ItemTradingRepository { get => _itemTradingRepository ?? (_itemTradingRepository = new QutationGenericRepository<ItemTrading>(_context)); }

public async Task SaveAsync()
{
   await this._context.SaveChangesAsync();
}

protected virtual void Dispose(bool disposing)
{
   if (!this.disposed)
   {
       if (disposing)
       {
           _context.Dispose();
       }
   }
   this.disposed = true;
}

public void Dispose()
{
   Dispose(true);
   System.GC.SuppressFinalize(this);
}
*/
        //public override BaseDBContext FactorContext(string constr) => new QutationContext(constr);
        public QutationUnitOfWork(QutationContext context) : base(context)
        {
        }
    }
}
