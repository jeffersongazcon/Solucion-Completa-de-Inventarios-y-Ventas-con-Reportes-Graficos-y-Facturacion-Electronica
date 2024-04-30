using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Logica_
{
    public class BLL_Listar
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-A96HL7MU\\SQLEXPRESS;database= SistemaDeUsuario; integrated security = true");
        public DataSet ListasUsusarios()
        {
            SqlCommand comando = new SqlCommand("ListasUsuarios", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@inicio", Usuario.inicio);
            comando.Parameters.AddWithValue("@final", Usuario.final);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            return dt;
        }

    }
}
