using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    internal interface AccesoDatoUsers
    {
        void add(Usuario usuario);
        void Edit(Usuario usuario);
        void Delete(Usuario usuario);
        IEnumerable<Usuario> GetAll();
        IEnumerable<Usuario> GetByValue();
    }
}
