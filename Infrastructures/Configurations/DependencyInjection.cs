using BE.TaskManagement.Infrastructures.Persistence.Repository;

namespace BE.TaskManagement.Infrastructures.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureInfrastructureDi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}