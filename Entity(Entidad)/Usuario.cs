using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Windows.Forms;
namespace Entity_Entidad_
{
    public abstract class Usuario
    {
        
        public static int IdUser { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static string FirsName { get; set; }
        public static string LastName { get; set; }
        public static string Cargo { get; set; }
        public static string Email { get; set; }

        public static int inicio { get; set;}
        public static int final { get; set;}

    }
}
