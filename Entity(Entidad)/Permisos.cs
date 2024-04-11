using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Permisos
    {
        public int AfinidadPermiso { get; set; }
        public string TipoDeMenu { get; set; }
        public string FechaRegistro { get; set; }
        public Cargo TipoDeCargo { get; set; }
    }
}
