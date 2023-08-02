using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System.Data;
using BE.TaskManagement.Domains.Context;

namespace BE.TaskManagement.Infrastructures.Persistence.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbContextFactory<TaskManagementDbContext> _contextFactory;

        public Repository(IDbContextFactory<TaskManagementDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        protected TaskManagementDbContext DbContext => _contextFactory.CreateDbContext();

        public TEntity Get(Guid id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbContext.Set<TEntity>().AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            DbContext.Set<TEntity>().Update(entity);
        }

        public void UpdateRange(IList<TEntity> entities)
        {
            DbContext.Set<TEntity>().UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IList<TEntity> entities)
        {
            DbContext.Set<TEntity>().RemoveRange(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
            return GetAll(false, null);
        }

        public IQueryable<TEntity> GetAll(bool isUntrackedEntities)
        {
            return GetAll(isUntrackedEntities, null);
        }

        public IQueryable<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includeFn)
        {
            return GetAll(false, includeFn);
        }

        public IQueryable<TEntity> GetAll(bool isUntrackedEntities, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includeFn)
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>();

            if (isUntrackedEntities)
            {
                query = query.AsNoTracking();
            }

            if (includeFn != null)
            {
                query = includeFn(query);
            }

            return query;
        }

        public IQueryable<TEntity> FromSqlRaw(string query, params object[] parameters)
        {
            return DbContext.Set<TEntity>().FromSqlRaw(query, parameters);
        }

        public void CheckRowVersion(long existing, long incoming, string message)
        {
            if (existing == incoming)
            {
                return;
            }

            throw new DBConcurrencyException(message);
        }
    }
}
