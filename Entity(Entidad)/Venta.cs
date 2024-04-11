using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Venta
    {
        public string AfiliacionVenta{ get; set; }
        public Usuario Usuario { get; set; }
        public string Factura { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente{ get; set; }
        public decimal MontoPago{get; set; }
        public decimal MontoCambio {  get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
    }
}
