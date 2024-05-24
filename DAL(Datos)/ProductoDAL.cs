using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DAL_Datos_;
using Entity_Entidad_;

public class ProductoDAL : ConexionBaseDeUsuario
{

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

    public void ReseedIdentity()
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();

            var queryMaxID = "SELECT ISNULL(MAX(ProductoID), 0) AS MaxID FROM Products";
            int maxID = 0;

            using (var command = new SqlCommand(queryMaxID, conn))
            {
                maxID = (int)command.ExecuteScalar();
            }


            var reseedQuery = $"DBCC CHECKIDENT ('Products', RESEED, {maxID})";

            using (var command = new SqlCommand(reseedQuery, conn))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void AddProducto(Producto producto)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            ReseedIdentity();
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
    public void Venta(int productoID, int cantidadAVender)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "UPDATE Products SET Cantidad = CASE WHEN Cantidad >= @Cantidad THEN Cantidad - @Cantidad ELSE 0 END WHERE ProductoID = @ProductoID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Cantidad", cantidadAVender);
                command.Parameters.AddWithValue("@ProductoID", productoID);
                command.ExecuteNonQuery();
            }
        }
    }

    public int GetCantidadActual(int productoID)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "SELECT Cantidad FROM Products WHERE ProductoID = @ProductoID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ProductoID", productoID);
                return (int)command.ExecuteScalar();
            }
        }
    }

    public DataTable GetAllCategorias()
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "SELECT DISTINCT Categoria FROM Products";
            using (var command = new SqlCommand(query, conn))
            {
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    public DataTable GetAllNombres()
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "SELECT DISTINCT Nombre FROM Products";
            using (var command = new SqlCommand(query, conn))
            {
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

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


