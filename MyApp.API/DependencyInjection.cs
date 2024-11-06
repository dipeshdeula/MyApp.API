using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
               .AddInfrastructureDI();
            return services;
        }
    }
}
