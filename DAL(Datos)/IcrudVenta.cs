using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudVenta
    {
        string Add(Venta venta);
        string Update(Venta venta);
        string Delete(Venta venta);
        List<Venta> GetAll();
    }
}
