using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE.TaskManagement.Domains.Entities.EntitiesConfiguration
{
    public class TaskCategoryConfiguration : IEntityTypeConfiguration<TaskCategory>
    {
        public void Configure(EntityTypeBuilder<TaskCategory> builder)
        {
            builder.Property(taskCategory => taskCategory.Name)
                .HasMaxLength(200);

            builder.Property(taskCategory => taskCategory.Description)
                .HasMaxLength(3000);

            builder.HasIndex(taskCategory => new { taskCategory.Name, taskCategory.Description });
        }
    }
}
