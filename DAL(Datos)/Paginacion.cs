using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public class Paginacion:ConexionBaseDeUsuario
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

        public DataSet ListasProductos()
        {
            SqlCommand comando = new SqlCommand("ListaProductos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@inicio", Producto.inicioProducto);
            comando.Parameters.AddWithValue("@final", Producto.finalProducto);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet datoProducto = new DataSet();
            adapter.Fill(datoProducto);
            return datoProducto;
        }

    }
}
