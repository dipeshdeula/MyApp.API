using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                opt => opt.UseSqlServer("Server=Dipesh;Database=CleanArchitectureDB;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true"));

            services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            return services;
        }
    }
}
