using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudCompra
    {
        string Add(Compra compra);
        string Update(Compra compra);
        string Delete(Compra compra);
        List<Compra> GetAll();
    }
}
