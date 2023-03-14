using DatabaseSync.Infrastructure.Interfaces;
using DatabaseSync.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseSync.Infrastructure
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserContext>(options =>
              options.UseSqlServer(
                  configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IMt4UserRepository, Mt4UserRepository>();

            return services;
        }

    }
}
