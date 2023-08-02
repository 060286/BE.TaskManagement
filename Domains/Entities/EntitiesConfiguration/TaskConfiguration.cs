using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BE.TaskManagement.Domains.Entities.EntitiesConfiguration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.Property(task => task.Name)
                .HasMaxLength(500);

            builder.Property(task => task.Description)
                .HasMaxLength(3000);

            builder.HasIndex(task => new { task.Name, task.Description });

            // One to many 
            builder.HasOne(task => task.TaskCategory)
                .WithMany(taskCategory => taskCategory.Tasks)
                .HasForeignKey(task => task.TaskCategoryId)
                .IsRequired();
        }
    }
}
