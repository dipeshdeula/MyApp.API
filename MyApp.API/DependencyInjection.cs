using MyApp.Application;
using MyApp.Core;
using MyApp.Infrastructure;

namespace MyApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
               .AddInfrastructureDI()
               .AddCoreDI(configuration);
            return services;
        }
    }
}
