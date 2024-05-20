using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Datos_
{
    public abstract class ConexionBaseDeUsuario
    {
        private readonly string connectionString;
        public ConexionBaseDeUsuario()
        {
            
            connectionString = "server=.\\SQLEXPRESS;database= SistemaDeUsuario; integrated security = true";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
