using BE.TaskManagement.Domains.Context;
using Microsoft.EntityFrameworkCore;

namespace BE.TaskManagement.Infrastructures.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOrWork
    {
        private readonly IDbContextFactory<TaskManagementDbContext> _contextFactory;

        public UnitOfWork(IDbContextFactory<TaskManagementDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public int Complete()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
