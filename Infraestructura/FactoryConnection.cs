using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Infraestructura
{
    public class FactoryConnection : IFactoryConnection
    {
        private IDbConnection _connection;
        private readonly IOptions<ConexionBD> _configs;
        public FactoryConnection(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CloseConnection()
        {
            if ( _connection != null && _connection.State == ConnectionState.Open )
            {
                _connection.Close();
            }
        }

        public IDbConnection GetDbConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_configs.Value.CadenaConexion);
            }

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }
    }
}