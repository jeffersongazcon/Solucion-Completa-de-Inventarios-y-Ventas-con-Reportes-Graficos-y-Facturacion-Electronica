using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    internal class Conexion
    {
        public static string Vinculo = ConfigurationManager.ConnectionStrings["VinculoConexion"].ToString();
    }
}
