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
    public class IcrudUsuario
    {
        public List<Usuario> Lista() 
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(Conexion.Vinculo))
            {
                try
                {
                    string consulta = "Select AfinidadUsuario,Documento,Nombre,Clave,Estado from Usuario";

                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    using(SqlDataReader leer = cmd.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                AfinidadUsuario = Convert.ToInt32(leer["AfinidadUsuario"]),
                                Documento = Convert.ToInt32(leer["Docmento"]),
                                Nombre = leer["Nombre"].ToString(),
                                Clave = leer["Clave"].ToString(),
                                Estado = Convert.ToBoolean(leer["Estado"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Lista = new List<Usuario>();
                    throw;
                }

            }
            return Lista;
        }
    }
}
