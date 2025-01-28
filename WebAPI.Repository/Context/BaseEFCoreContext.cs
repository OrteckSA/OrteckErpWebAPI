using Common.Domain;
using Common.Domain.UnitOfWork;
using ERP_Integration.Repository.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ERP_Integration.Repository.Context
{
    public abstract class BaseEFCoreContext : DbContext, IDBContext
    {
        ITransaction currenctTransaction = null;

        public BaseEFCoreContext(DbContextOptions options) : base(options)
        {
        }

        ITransaction IDBContext.CurrentTransaction => currenctTransaction;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.HasDbFunction(typeof(CommonDbFunctionsExtensions).GetMethod(nameof(CommonDbFunctionsExtensions.JsonValue), new[] { typeof(string), typeof(string) }))
            //.HasTranslation((args) => BaseEFCoreContext.JsonValue(args[0], args[1]));
        }
        [DbFunction("JSON_VALUE", IsBuiltIn = true, IsNullable = false)]
        public static string JsonValue(string expression, string path) => throw new NotImplementedException();
        public ITransaction BeginTransaction()
        {
            currenctTransaction = new EFCoreTransaction(Database.BeginTransaction());
            return currenctTransaction;
        }
        void IDBContext.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }
        void IDBContext.AddOrUpdate<T>(T entity)
        {
            Set<T>().Update(entity);
        }
        void IDBContext.AddRange<T>(IEnumerable<T> entities)
        {
            Set<T>().AddRange(entities);
        }
        void IDBContext.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }
        void IDBContext.RemoveRange<T>(IEnumerable<T> entity)
        {
            Set<T>().RemoveRange(entity);
        }
        void IDBContext.SetValuesOnAdd<IEntity>(IEnumerable<IEntity> entities)
        {
            foreach (var entity in entities)
                (this as IDBContext).SetValuesOnAdd(entity);            
        }
        void IDBContext.SetValuesOnDelete<IEntity>(IEnumerable<IEntity> entities)
        {
            foreach (var entity in entities)
                (this as IDBContext).SetValuesOnDelete(entity);            
        }
        void IDBContext.SetValuesOnGet<IEntity>(IEnumerable<IEntity> entities)
        {
            foreach (var entity in entities)
                (this as IDBContext).SetValuesOnGet(entity);            
        }
        void IDBContext.SetValuesOnUpdate<IEntity>(IEnumerable<IEntity> entities)
        {
            foreach (var entity in entities)
                (this as IDBContext).SetValuesOnUpdate(entity);            
        }
        void IDBContext.SaveChanges()
        {
            SaveChanges();
        }
        async Task IDBContext.SaveChangesAsync()
        {
            await SaveChangesAsync();
        }
        IQueryable<T> IDBContext.Set<T>()
        {
            return Set<T>();
        }
        async Task IDBContext.ExecuteSqlCommandAsync(string query, params object[] parameters)
        {
            await Database.ExecuteSqlRawAsync(query, parameters);
        }

        public abstract void SetValuesOnAdd<IEntity>(IEntity entity) where IEntity : class;
        public abstract void SetValuesOnDelete<IEntity>(IEntity entity) where IEntity : class;
        public abstract void SetValuesOnGet<IEntity>(IEntity entity) where IEntity : class;
        public abstract void SetValuesOnUpdate<IEntity>(IEntity entity) where IEntity : class;

        public async Task<T> GetAsync<T>(Expression<Func<T, bool>> filter) where T : class
        {
            if (filter != null)
                return await Set<T>().Where(filter).FirstOrDefaultAsync();
            return await Set<T>().FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetListAsync<T>(Expression<Func<T, bool>> filter) where T : class
        {
            if (filter != null)
                return await Set<T>().Where(filter).ToListAsync();
            return await Set<T>().ToListAsync();
        }
    }
}
