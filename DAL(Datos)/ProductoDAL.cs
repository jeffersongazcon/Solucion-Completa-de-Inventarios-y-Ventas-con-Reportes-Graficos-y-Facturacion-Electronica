using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DAL_Datos_;
using Entity_Entidad_; // Referencia a la clase Producto

public class ProductoDAL : ConexionBaseDeUsuario
{
    // Leer todos los productos
    public DataTable GetAllProductos()
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "SELECT * FROM Products";
            using (var command = new SqlCommand(query, conn))
            {
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    // Agregar un nuevo producto
    public void AddProducto(Producto producto)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "INSERT INTO Products (CodigoDeBarras, Nombre, DescripcionProducto, Categoria, Cantidad, PrecioCompra, PrecioVenta, Estado, FechaRegistro) VALUES (@CodigoDeBarras, @Nombre, @DescripcionProducto, @Categoria, @Cantidad, @PrecioCompra, @PrecioVenta, @Estado, @FechaRegistro)";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CodigoDeBarras", producto.CodigoDeBarras);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@FechaRegistro", producto.FechaRegistro);

                command.ExecuteNonQuery();
            }
        }
    }

    // Actualizar un producto existente
    public void UpdateProducto(Producto producto)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "UPDATE Products SET CodigoDeBarras = @CodigoDeBarras, Nombre = @Nombre, DescripcionProducto = @DescripcionProducto, Categoria = @Categoria, Cantidad = @Cantidad, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, Estado = @Estado WHERE ProductoID = @ProductoID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ProductoID", producto.ProductoID);
                command.Parameters.AddWithValue("@CodigoDeBarras", producto.CodigoDeBarras);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Estado", producto.Estado);

                command.ExecuteNonQuery();
            }
        }
    }

    // Eliminar un producto
    public void DeleteProducto(int productoID)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "DELETE FROM Products WHERE ProductoID = @ProductoID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ProductoID", productoID);
                command.ExecuteNonQuery();
            }
        }
    }


}

