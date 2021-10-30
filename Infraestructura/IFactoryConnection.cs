using System.Data;

namespace Infraestructura
{
    public interface IFactoryConnection
    {
         void CloseConnection();
         IDbConnection GetDbConnection();
    }
}