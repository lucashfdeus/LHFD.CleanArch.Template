using LHFD.CleanArch.Domain.Interfaces;
using LHFD.CleanArch.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LHFD.CleanArch.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureSdk<TContext>(this IServiceCollection services,
            IConfiguration configuration, 
             string connectionStringName = "DefaultConnection") where TContext : DbContext
        {
            services.AddDbContext<TContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));

            services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            return services;
        }
    }
}