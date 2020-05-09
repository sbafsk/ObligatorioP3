using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Repositorios
{
    class RepoCliente : IRepositorio<Cliente>
    {
        public bool Alta(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificacion(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
