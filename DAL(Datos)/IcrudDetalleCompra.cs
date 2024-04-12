using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudDetalleCompra
    {
        string Add(DetalleCompra detalleCompra);
        string Update(DetalleCompra detalleCompra);
        string Delete(DetalleCompra detalleCompra);
        List<DetalleCompra> GetAll();
    }
}
