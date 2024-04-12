using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudDetalleVenta
    {
        string Add(DetalleVenta detalleVenta);
        string Update(DetalleVenta detalleVenta);
        string Delete(DetalleVenta detalleVenta);
        List<DetalleVenta> GetAll();
    }
}
