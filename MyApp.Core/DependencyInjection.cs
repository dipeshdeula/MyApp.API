using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreDI (this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
            //services.Configure<CoindeskApiOptions>(configuration.GetSection(CoindeskApiOptions.BaseName));
            return services;
        }
    }
}
