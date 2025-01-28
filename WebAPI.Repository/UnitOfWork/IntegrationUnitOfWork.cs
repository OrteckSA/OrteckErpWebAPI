using Common.Domain;
using ERP.Repository.UnitOfWork;
using ERP_Integration.Domain.UnitOfWork;
using ERP_Integration.Repository.Context;

namespace ERP_Integration.Repository.UnitOfWork
{
    public class IntegrationUnitOfWork : UnitOfWorkBase, IIntegrationUnitOfWork
    {
        /*
        private bool disposed = false;
        private readonly IntegrationContext _context;

        private IGenericRepository<Transaction> _transactionsRepository;
        private IGenericRepository<TransactionError> _transactionErrorRepository;
        private IGenericRepository<Payment> _paymentRepository;
        private IGenericRepository<PaymentError> _paymentErrorRepository;
        private IGenericRepository<RequestTypeMap> _requestTypeMapRepository;
        private IGenericRepository<Setting> _settingRepository;
        private IGenericRepository<BanksMap> _banksMapRepository;
        private IGenericRepository<CustomerAccountMap> _customerAccountMapRepository;
        private IGenericRepository<EmployeeAccountMap> _employeeAccountMapRepository;
        private IGenericRepository<CustomerIntegration> _customerRepository;
        private IGenericRepository<SalespersonIntegration> _salespersonIntegrationRepository;
        private IGenericRepository<States> _statesRepository;

        public IntegrationUnitOfWork(IntegrationContext context)
        {
            _context = context;
        }

        public IGenericRepository<Transaction> TransactionsRepository { get => _transactionsRepository ?? (_transactionsRepository = new IntegrationGenericRepository<Transaction>(_context)); }
        public IGenericRepository<TransactionError> TransactionErrorRepository { get => _transactionErrorRepository ?? (_transactionErrorRepository = new IntegrationGenericRepository<TransactionError>(_context)); }
        public IGenericRepository<Payment> PaymentRepository { get => _paymentRepository ?? (_paymentRepository = new IntegrationGenericRepository<Payment>(_context)); }
        public IGenericRepository<PaymentError> PaymentErrorRepository { get => _paymentErrorRepository ?? (_paymentErrorRepository = new IntegrationGenericRepository<PaymentError>(_context)); }
        public IGenericRepository<RequestTypeMap> RequestTypeMapRepository { get => _requestTypeMapRepository ?? (_requestTypeMapRepository = new IntegrationGenericRepository<RequestTypeMap>(_context)); }
        public IGenericRepository<Setting> SettingRepository { get => _settingRepository ?? (_settingRepository = new IntegrationGenericRepository<Setting>(_context)); }
        public IGenericRepository<BanksMap> BanksMapRepository { get => _banksMapRepository ?? (_banksMapRepository = new IntegrationGenericRepository<BanksMap>(_context)); }
        public IGenericRepository<CustomerAccountMap> CustomerAccountMapRepository { get => _customerAccountMapRepository ?? (_customerAccountMapRepository = new IntegrationGenericRepository<CustomerAccountMap>(_context)); }
        public IGenericRepository<EmployeeAccountMap> EmployeeAccountMapRepository { get => _employeeAccountMapRepository ?? (_employeeAccountMapRepository = new IntegrationGenericRepository<EmployeeAccountMap>(_context)); }
        public IGenericRepository<CustomerIntegration> CustomerRepository { get => _customerRepository ?? (_customerRepository = new IntegrationGenericRepository<CustomerIntegration>(_context)); }
        public IGenericRepository<SalespersonIntegration> SalespersonIntegrationRepository { get => _salespersonIntegrationRepository ?? (_salespersonIntegrationRepository = new IntegrationGenericRepository<SalespersonIntegration>(_context)); }
        public IGenericRepository<States> StatesRepository { get => _statesRepository ?? (_statesRepository = new IntegrationGenericRepository<States>(_context)); }

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
        //public IntegrationUnitOfWork(string connectionString) : base(connectionString)
        //{
        //}

        //public override BaseDBContext FactorContext(string constr) => new IntegrationContext(constr);
        public IntegrationUnitOfWork(IntegrationContext context) : base(context)
        {
        }
    }
}
