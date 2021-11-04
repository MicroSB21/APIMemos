using Aplicacion;
using Aplicacion.Acciones;
using Infraestructura.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructura
{
    public static class ServiceRegistration
    {
        public static void AddInfraestructure(this IServiceCollection services)
        {
            services.AddTransient<IAccionRepository, AccionRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

        }
    }
}