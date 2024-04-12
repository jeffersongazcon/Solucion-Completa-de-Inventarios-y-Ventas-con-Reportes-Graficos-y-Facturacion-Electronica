using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Compra
    {
        public string AfiliacionCompra { get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Factura { get; set; }
        public string Documento { get; set; }
        public decimal PrecioTotal { get; set; }
        public string FechaRegistro { get; set; }
        public List<DetalleCompra> DetalleCompras {get;set;}
    }
}
