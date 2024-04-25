using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudCargo
    {
        string Add(cargo cargo);
        string Update(cargo cargo);
        string Delete(cargo cargo);
        List<cargo> GetAll();
    }
}
