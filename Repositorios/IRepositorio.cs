using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Repositorios
{
    public interface IRepositorio<T>
    {
        bool Alta(T obj);
        bool Baja(int id);
        bool Modificacion(T obj);
        List<T> ListarTodo();
        T BuscarPorId(int id);
    }
}
