using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class DetalleCompra
    {
        public int ID {  get; set; }
        public Producto Producto {  get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad {  get; set; }
        public decimal PrecioTotal {  get; set; }
        public string FechaRegistro { get; set; }


    }
}
