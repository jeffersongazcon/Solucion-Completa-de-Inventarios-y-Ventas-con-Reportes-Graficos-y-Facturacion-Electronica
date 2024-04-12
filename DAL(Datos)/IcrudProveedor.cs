using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudProveedor
    {
        string Add(Proveedor proveedor);
        string Update(Proveedor proveedor);
        string Delete(Proveedor proveedor);
        List<Proveedor> GetAll();
    }
}
