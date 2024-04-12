using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Cliente
    {
        public int AfiliacionCliente { get; set; }
        public int Documento { get; set; }
        public int Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro {  get; set; }
        public Cargo Cargo {  get; set; }
    }
}
