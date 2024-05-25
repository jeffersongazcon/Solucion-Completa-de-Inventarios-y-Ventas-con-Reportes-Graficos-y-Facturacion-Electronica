using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Factura
    {
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public int PrecioCompra { get; set; }

        public DateTime FechaVenta { get; set; }
    }
}
