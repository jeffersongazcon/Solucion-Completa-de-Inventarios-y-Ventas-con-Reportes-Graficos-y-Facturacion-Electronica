using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Entidad_
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Nombre { get; set;}
        public string DescripcionProducto { get; set;}
        public  string Categoria  { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Estado {  get; set; }
        public string FechaRegistro {  get; set; }
        public static int inicioProducto { get; set; }
        public static int finalProducto { get; set; }
    }
}
