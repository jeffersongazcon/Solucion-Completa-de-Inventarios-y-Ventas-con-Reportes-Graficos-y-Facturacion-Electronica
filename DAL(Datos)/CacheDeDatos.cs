using System;
using System.Data;
using System.Data.SqlClient;

public class CacheDeDatos
{
    private readonly string _connectionString = "server=LAPTOP-A96HL7MU\\SQLEXPRESS;database=SistemaDeUsuario;integrated security=true";

    public SqlConnection GetSqlConnection()
    {
        return new SqlConnection(_connectionString);
    }

    public DataTable GetAllUsuarios()
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "SELECT * FROM Users";
            using (var command = new SqlCommand(query, conn))
            {
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    public void AddUsuario(string loginName, string password, string firstName, string lastName, string cargo, string email)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "INSERT INTO Users (LoginName, Password, FirsName, LastName, Cargo, Email) VALUES (@LoginName, @Password, @FirsName, @LastName, @Cargo, @Email)";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@LoginName", loginName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FirsName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Cargo", cargo);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateUsuario(int id, string loginName, string password, string firstName, string lastName, string cargo, string email)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "UPDATE Users SET LoginName = @LoginName, Password = @Password, FirsName = @FirsName, LastName = @LastName, Cargo = @Cargo, Email = @Email WHERE UserID= @UserID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", id);
                command.Parameters.AddWithValue("@LoginName", loginName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FirsName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Cargo", cargo);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteUsuario(int id)
    {
        using (var conn = GetSqlConnection())
        {
            conn.Open();
            var query = "DELETE FROM Users WHERE UserID = @UserID";
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
