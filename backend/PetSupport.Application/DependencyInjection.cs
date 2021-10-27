using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace PetSupport.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPetSupportApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}