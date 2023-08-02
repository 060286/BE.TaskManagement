using BE.TaskManagement.Infrastructures.Persistence.BaseEntity;

namespace BE.TaskManagement.Domains.Entities
{
    public class TaskCategory : BaseEntity, IKey<Guid>
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public IList<Task>? Tasks { get; set; }
    }
}
