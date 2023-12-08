using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Application.Services;
using TodoTask.Domain.Ports.Inbound;
using TodoTask.Infrastructure.Persistence.Repositories;

namespace TodoTask.Application.Configuration
{
    public static class ApplicationAdapterConfiguration
    {
        public static IServiceCollection AddApplicationAdapters(this IServiceCollection services)
        {
            // DI
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<IRequestService, RequestService>();
            return services;
        }
    }
}
