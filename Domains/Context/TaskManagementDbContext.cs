using BE.TaskManagement.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BE.TaskManagement.Domains.Context
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Task> Tasks { get; set; }

        public DbSet<TaskCategory> TaskCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedData(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskCategory>()
                .HasData(new List<TaskCategory>
                {
                    new TaskCategory
                    {
                        Id = new Guid("d3bfa89b-1d12-4036-811d-deb2de249f97"),
                        Name = "Home Task",
                        Description = "Home Description",
                    }
                });

            modelBuilder.Entity<Entities.Task>()
                .HasData(new List<Entities.Task>
                {
                    new Entities.Task
                    {
                        Id = new Guid("67d58d2e-da3a-4d0a-99c4-2df3dd537a84"),
                        Name = "Washing dishes",
                        Description = "Washing dishes description",
                        TaskCategoryId = new Guid("d3bfa89b-1d12-4036-811d-deb2de249f97")
                    },
                    new Entities.Task
                    {
                        Id = new Guid("af47529b-66b1-4d70-b936-f12b73ecd765"),
                        Name = "Cooking or preparing meals",
                        Description = "Cooking or preparing meals description",
                        TaskCategoryId = new Guid("d3bfa89b-1d12-4036-811d-deb2de249f97")
                    }
                });
        }
    }
}
