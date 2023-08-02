using BE.TaskManagement.Domains.Context;
using BE.TaskManagement.Infrastructures.Constants;
using Microsoft.EntityFrameworkCore;

namespace BE.TaskManagement.Domains.Configurations
{
    public static class DependencyInjection
    {
        public static void ConfigureDatabase(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContextFactory<TaskManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(DatabaseConstant.DefaultConnectionString),
                    sqlServer => sqlServer.EnableRetryOnFailure(2)
                        .CommandTimeout(120)
                        .MigrationsHistoryTable("__EFMigrationHistory", DatabaseConstant.DefaultSchema)));
        }
    }
}
