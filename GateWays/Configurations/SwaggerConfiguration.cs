
namespace BE.TaskManagement.GateWays.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(setup => setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Task Management",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact
                {
                    Email = "tamle.dev@gmail.com",
                    Name = "Tam Le",
                },
                License = new Microsoft.OpenApi.Models.OpenApiLicense
                {
                    Name = "License",
                },
                Description = "This project is inspired by clean architecture!"
            }));
        }
    }
}
