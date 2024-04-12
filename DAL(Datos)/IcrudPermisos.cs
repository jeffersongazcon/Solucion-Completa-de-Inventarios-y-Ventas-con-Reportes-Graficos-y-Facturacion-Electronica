using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudPermisos
    {
        string Add(Permisos permisos);
        string Update(Permisos permisos);
        string Delete(Permisos permisos);
        List<Permisos> GetAll();
    }
}
