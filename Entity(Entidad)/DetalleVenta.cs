using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public Producto producto { get; set; }
        public decimal PrecioVenta {get; set;}
        public int Cantidad { get; set;}
    }
}
