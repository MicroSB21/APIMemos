using Aplicacion.Acciones;

namespace Aplicacion
{
    public interface IUnitOfWork
    {
         IAccionRepository Acciones { get; }
    }
}