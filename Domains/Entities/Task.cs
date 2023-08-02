using BE.TaskManagement.Infrastructures.Persistence.BaseEntity;

namespace BE.TaskManagement.Domains.Entities
{
    public class Task : BaseEntity, IKey<Guid>
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public Guid TaskCategoryId { get; set; }

        public virtual TaskCategory TaskCategory { get; set; }
    }
}
