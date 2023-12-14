using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTask.Infrastructure.Extensions
{
    public static class ServiceSwaggerAddGenExtension
    {
        public static IServiceCollection AddExtensionSwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                //opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    In = ParameterLocation.Header,
                //    Description = "Insert JWT Token",
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.ApiKey
                //});
            });

            return services;
        }
    }
}
