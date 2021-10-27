using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetSupport.Application.Contracts_Interfaces.Persistence;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace PetSupport.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPetSupportPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<PetSupportDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PetSupportConnectionString"),
                        options => options.MigrationsAssembly("PetSupport.API"))
                    .EnableSensitiveDataLogging());
            
            services.AddScoped<IPetSupportDbContext, PetSupportDbContext>();
            return services;
        }
    }
}