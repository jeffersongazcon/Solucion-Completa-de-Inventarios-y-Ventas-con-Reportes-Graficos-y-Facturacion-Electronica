using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudBase <T>
    {
        string Add (T entidad);
        string Update (T entidad);
        string Delete (T entidad);
        List<T> GetAll ();
    }
}
