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
    public class Paginacion : ConexionBaseDeUsuario
    {
        public DataSet ListasUsusarios()
        {
            using (var conneccion = GetSqlConnection())
            {
                conneccion.Open();
                SqlCommand comando = new SqlCommand("ListasUsuarios", conneccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@inicio", Usuario.inicio);
                comando.Parameters.AddWithValue("@final", Usuario.final);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;
            }

        }

        public DataSet ListasProductos()
        {
            using (var conneccion = GetSqlConnection())
            {
                conneccion.Open();
                SqlCommand comando = new SqlCommand("ListaProductos", conneccion);
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
}
