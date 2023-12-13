using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Infrastructure.Extensions
{
    public static class ServiceSwaggerAddGenExtension
    {
        public static IServiceCollection AddServiceSwaggerGen(this IServiceCollection services)
        {
            //services.AddSwaggerGen();

            return services;
        }
    }
}
