using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Usuario
    {
        public int AfinidadUsuario { get; set; }
        public string Documento { get; set; }
        public string Nombre {get; set;}
        public string Clave { get; set;}
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
        public Cargo IdCargo { get; set; }
    }
}
