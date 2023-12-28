using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Services;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Services;

namespace TodoTask.Application.Configuration
{
    public static class ApplicationAdapterConfiguration
    {
        public static IServiceCollection AddExtensionApplicationAdapters(this IServiceCollection services)
        {
            // DI
            services.AddScoped<IDriverService, DriverService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IVehicleService, VehicleService>();

            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<IPasswordEncryptionService, PasswordEncryptionService>();
            
            return services;
        }
    }
}
