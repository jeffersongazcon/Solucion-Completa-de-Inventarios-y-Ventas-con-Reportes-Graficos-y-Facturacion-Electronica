using DAL_Datos_;
using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Logica_
{
    public class BLL_Usuario
    {
        private IcrudUsuario DatosUsuario = new IcrudUsuario();
        public bool Login(string username, string password)
        {
            return DatosUsuario.Login(username, password);
        }
        public List<Usuario> Lista()
        {
            return DatosUsuario.Lista();
        }
    }


}
