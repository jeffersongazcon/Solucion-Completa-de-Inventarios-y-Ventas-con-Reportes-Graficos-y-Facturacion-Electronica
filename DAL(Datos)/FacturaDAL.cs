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
    public class FacturaDAL : ConexionBaseDeUsuario
    {
        public DataTable GetAllFactura()
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                var query = "SELECT * FROM Factura";
                using (var command = new SqlCommand(query, conn))
                {
                    var adapter = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void AddFactura(Factura factura)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();

                var query = "INSERT INTO Factura (Producto, Descripcion, Precio, Cantidad, Total, PrecioCompra, FechaVenta, NombreCliente) VALUES (@Producto, @Descripcion, @Precio, @Cantidad, @Total, @PrecioCompra, @FechaVenta, @NombreCliente)";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Producto", factura.Producto);
                    command.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                    command.Parameters.AddWithValue("@Precio", factura.Precio);
                    command.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                    command.Parameters.AddWithValue("@Total", factura.Total);
                    command.Parameters.AddWithValue("@PrecioCompra", factura.PrecioCompra);
                    command.Parameters.AddWithValue("@FechaVenta", DateTime.Now);
                    command.Parameters.AddWithValue("@NombreCliente", factura.NombreCliente);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetVentasPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Factura WHERE FechaVenta BETWEEN @FechaInicio AND @FechaFinal";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@FechaFinal", fechaFinal);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable ventasTable = new DataTable();
                adapter.Fill(ventasTable);

                return ventasTable;
            }
        }

        public DataTable GetProductosVendidos()
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ProductosVendidos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTop5Productos()
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TopDeProductosPreferidos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTop5ProductosMenos()
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TopDeProductosMenosPreferidos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void GetGrafico(out decimal cantidadInvertida, out decimal ganancia, out int cantidadDeClientes, out int numeroDeCategorias, out int cantidadDeProductos)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Grafico", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramCantidadInvertida = new SqlParameter("@catidadInvertida", SqlDbType.Decimal);
                paramCantidadInvertida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramCantidadInvertida);

                SqlParameter paramGanancia = new SqlParameter("@ganancia", SqlDbType.Decimal);
                paramGanancia.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramGanancia);

                SqlParameter paramCantidadDeClientes = new SqlParameter("@cantidadDeClientes", SqlDbType.Int);
                paramCantidadDeClientes.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramCantidadDeClientes);

                SqlParameter paramNumeroDeCategorias = new SqlParameter("@numeroDeCategorias", SqlDbType.Int);
                paramNumeroDeCategorias.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramNumeroDeCategorias);

                SqlParameter paramCantidadDeProductos = new SqlParameter("@cantidadDeProductos", SqlDbType.Int);
                paramCantidadDeProductos.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramCantidadDeProductos);

                cmd.ExecuteNonQuery();

                cantidadInvertida = (decimal)paramCantidadInvertida.Value;
                ganancia = (decimal)paramGanancia.Value;
                cantidadDeClientes = (int)paramCantidadDeClientes.Value;
                numeroDeCategorias = (int)paramNumeroDeCategorias.Value;
                cantidadDeProductos = (int)paramCantidadDeProductos.Value;
            }
        }
    }
}
