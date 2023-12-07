using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Persistence.Database;
//using TodoTask.Infrastructure.Persistence.Migrations;
using TodoTask.Infrastructure.Persistence.Repositories;

namespace TodoTask.Infrastructure.Configuration
{
    public static class DatabaseAdapterConfiguration
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string databaseConnection)
        {
            services.AddDbContext<TodoTaskDbContext>(options => options.UseSqlServer(databaseConnection));
            //services.AddHostedService<MigratorHostedService>();
            //services.AddTransient<IPandaPersistencePort, PandaPersistenceAdapter>();

            // Persistence
            services.AddScoped<IRequestRepository, RequestRepository>();
            return services;
        }
    }
}
