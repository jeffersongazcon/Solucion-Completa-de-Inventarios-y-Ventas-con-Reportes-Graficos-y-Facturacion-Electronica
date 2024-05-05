using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Logica_
{
    public class BLL_Cache
    {
        private readonly CacheDeDatos _usuarioDAL;

        public BLL_Cache()
        {
            _usuarioDAL = new CacheDeDatos();
        }

        public DataTable GetAllUsuarios()
        {
            return _usuarioDAL.GetAllUsuarios();
        }

        public void AddUsuario(string loginName, string password, string firstName, string lastName, string cargo, string email)
        {
            _usuarioDAL.AddUsuario(loginName, password, firstName, lastName, cargo, email);
        }

        public void UpdateUsuario(int id, string loginName, string password, string firstName, string lastName, string cargo, string email)
        {
            _usuarioDAL.UpdateUsuario(id, loginName, password, firstName, lastName, cargo, email);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioDAL.DeleteUsuario(id);
        }
    }

}
