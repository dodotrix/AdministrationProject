using Administration.DataAccess.Repositories;
using Administration.Domena.Repositories;
using Administration.Domena.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administration.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials());
            });
        }

        public static void ConfigureScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IPacijentRepository, PacijentRepository>();
            services.AddScoped<IPacijentService, PacijentService>();
        }
    }
}
