using Aplicacion;
using Aplicacion.Acciones;

namespace Infraestructura.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        public UnitOfWork(IAccionRepository accionRepository)
        {
            Acciones = accionRepository;
        }

        public IAccionRepository Acciones { get; }
    }
}