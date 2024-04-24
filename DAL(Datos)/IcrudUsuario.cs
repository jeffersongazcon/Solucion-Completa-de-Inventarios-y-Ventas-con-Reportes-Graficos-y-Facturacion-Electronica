using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity_Entidad_;
using System.ComponentModel.Design;


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
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
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
