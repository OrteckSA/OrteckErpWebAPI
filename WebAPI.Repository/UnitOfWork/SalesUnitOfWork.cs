using Common.Domain;
using ERP.Repository.UnitOfWork;
using ERP_Integration.Domain.UnitOfWork;
using ERP_Integration.Repository.Context;

namespace ERP_Integration.Repository.UnitOfWork
{
    public class SalesUnitOfWork : UnitOfWorkBase, ISalesUnitOfWork
    {
        //public SalesUnitOfWork(string connectionString) : base(connectionString)
        //{
        //}

        //public override BaseDBContext FactorContext(string constr) => new SalesContext(constr);
        public SalesUnitOfWork(SalesContext context) : base(context)
        {
        }
    }
}
