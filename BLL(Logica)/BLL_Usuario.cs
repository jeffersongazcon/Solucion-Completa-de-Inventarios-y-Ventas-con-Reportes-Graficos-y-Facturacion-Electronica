using DAL_Datos_;
using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Entidad_;
namespace BLL_Logica_
{
    public class BLL_Usuario
    {
        private IcrudUsuario DatosUsuario = new IcrudUsuario();

        public List<Usuario> Lista()
        {
            return DatosUsuario.Lista();
        }
    }
}
