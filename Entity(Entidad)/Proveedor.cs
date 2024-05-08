using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Proveedor
    {
        public int AfinidadProveedor { get; set; }
        public int Documento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set;}
        public bool Estado { get; set;}
        public string FechaRegistro { get; set;}
        public string Cargo { get; set;}
    }
}
