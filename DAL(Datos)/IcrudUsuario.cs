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

    }
}
