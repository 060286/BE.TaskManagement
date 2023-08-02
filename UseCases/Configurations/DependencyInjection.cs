using NetCore.AutoRegisterDi;

namespace BE.TaskManagement.UseCases.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServiceDi(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterAssemblyPublicNonGenericClasses()
                .Where(service => service.Name.EndsWith("Service"))
                .AsPublicImplementedInterfaces(ServiceLifetime.Scoped);

            return services;
        }
    }
}
