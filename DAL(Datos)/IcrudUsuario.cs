using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity_Entidad_;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


namespace DAL_Datos_
{
    public class IcrudUsuario:ConexionBaseDeUsuario
    {

        public bool Login(string user, string password)
        {
            using (var conneccion = GetSqlConnection())
            {
                conneccion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conneccion;
                    command.CommandText = "select *from Users where LoginName=@User and Password=@pass ";
                    command.Parameters.AddWithValue("@User",user);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@id", Usuario.IdUser);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Usuario.IdUser = reader.GetInt32(0);
                            Usuario.LoginName = reader.GetString(1);
                            Usuario.Password = reader.GetString(2);
                            Usuario.FirsName = reader.GetString(3);
                            Usuario.LastName = reader.GetString(4);
                            Usuario.Cargo = reader.GetString(5);
                            Usuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void ReseedIdentity()
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
               
                var queryMaxID = "SELECT ISNULL(MAX(UserID), 0) AS MaxID FROM Users";
                int maxID = 0;

                using (var command = new SqlCommand(queryMaxID, conn))
                {
                    maxID = (int)command.ExecuteScalar();
                }

                // Reiniciar el IDENTITY con el valor máximo
                var reseedQuery = $"DBCC CHECKIDENT ('Users', RESEED, {maxID})";

                using (var command = new SqlCommand(reseedQuery, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
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
                ReseedIdentity();
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
}
