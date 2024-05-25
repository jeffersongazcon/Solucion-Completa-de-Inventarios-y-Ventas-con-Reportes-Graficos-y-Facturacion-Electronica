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

                var query = "INSERT INTO Factura (Producto, Descripcion, Precio, Cantidad, Total, PrecioCompra, FechaVenta) VALUES (@Producto, @Descripcion, @Precio, @Cantidad, @Total, @PrecioCompra, @FechaVenta)";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Producto", factura.Producto);
                    command.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                    command.Parameters.AddWithValue("@Precio", factura.Precio);
                    command.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                    command.Parameters.AddWithValue("@Total", factura.Total);
                    command.Parameters.AddWithValue("@PrecioCompra", factura.PrecioCompra);
                    command.Parameters.AddWithValue("@FechaVenta", DateTime.Now);

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

    }
}
