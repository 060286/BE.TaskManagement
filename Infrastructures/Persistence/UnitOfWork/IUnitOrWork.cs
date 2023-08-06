using BE.TaskManagement.Domains.Context;

namespace BE.TaskManagement.Infrastructures.Persistence.UnitOfWork
{
    public interface IUnitOrWork
    {
        int Complete();

        void Dispose();
    }
}
