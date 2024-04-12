using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Datos_
{
    public interface IcrudCategoria
    {
        string Add(Categoria categoria);
        string Update(Categoria categoria);
        string Delete(Categoria categoria);
        List<Categoria> GetAll();
    }
}
