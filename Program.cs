
using BE.TaskManagement.Domains.Configurations;
using BE.TaskManagement.GateWays.Configurations;
using BE.TaskManagement.Infrastructures.Configurations;
using BE.TaskManagement.UseCases.Configurations;

namespace BE.TaskManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.ConfigureDatabase(builder.Configuration);
            builder.Services.ConfigureInfrastructureDi(builder.Configuration);
            builder.Services.ConfigureServiceDi(builder.Configuration);
            builder.Services.ConfigureApiVersioning();
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.ConfigureSwagger(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}