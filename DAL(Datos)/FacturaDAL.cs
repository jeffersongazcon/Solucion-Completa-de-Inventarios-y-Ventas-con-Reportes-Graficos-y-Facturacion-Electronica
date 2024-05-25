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

                var query = "INSERT INTO Factura (Producto, Descripcion, Precio, Cantidad, Total, PrecioCompra) VALUES (@Producto, @Descripcion, @Precio, @Cantidad, @Total, @PrecioCompra)";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Producto", factura.Producto);
                    command.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                    command.Parameters.AddWithValue("@Precio", factura.Precio);
                    command.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                    command.Parameters.AddWithValue("@Total", factura.Total);
                    command.Parameters.AddWithValue("@PrecioCompra", factura.PrecioCompra); // Asegúrate de que este valor se asigne correctamente

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
