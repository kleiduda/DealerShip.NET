using DealerShip.Data.Context;
using DealerShip.Data.Repository;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Notifications;
using DealerShip.Domain.Services.Implementations;
using DealerShip.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DealerShip.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<SqlContext>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<IVeiculoService, VeiculoServiceImplementation>();
            services.AddScoped<INotificador, Notificador>();
            //
            services.AddScoped<IMarcaService, MarcaServiceImplementation>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();

            return services;
        }
    }
}
