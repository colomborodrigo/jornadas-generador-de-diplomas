using Microsoft.Data.SqlClient;

namespace generador_de_diplomas
{
    public class ConexionSqlServer
    {
        
        public SqlConnection Connection { get; set; }

        public ConexionSqlServer(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}