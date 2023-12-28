using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Adapters;
using TodoTask.Infrastructure.Database;

//using TodoTask.Infrastructure.Persistence.Migrations;

namespace TodoTask.Infrastructure.Configuration
{
    public static class DatabaseAdapterConfiguration
    {
        public static IServiceCollection AddExtensionDatabaseConfig(this IServiceCollection services, string databaseConnection)
        {
            services.AddDbContext<TodoTaskDbContext>(options => options.UseSqlServer(databaseConnection));
            //services.AddHostedService<MigratorHostedService>();
            //services.AddTransient<IPandaPersistencePort, PandaPersistenceAdapter>();

            // Persistence
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            return services;
        }
    }
}
