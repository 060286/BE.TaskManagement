using Microsoft.EntityFrameworkCore.Query;

namespace BE.TaskManagement.Infrastructures.Persistence.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid id);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IList<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteRange(IList<TEntity> entities);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAll(bool isUntrackedEntities);

        IQueryable<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includeFn);

        IQueryable<TEntity> GetAll(bool isUntrackedEntities, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includeFn);

        IQueryable<TEntity> FromSqlRaw(string query, params object[] parameters);

        /// <summary>
        /// API for checking concurrent update.
        /// </summary>
        /// <param name="existing">Existing row version in database</param>
        /// <param name="incoming">Incoming row version from request</param>
        /// <param name="message">Message should be thrown when conflicting</param>
        void CheckRowVersion(long existing, long incoming, string message);
    }
}
