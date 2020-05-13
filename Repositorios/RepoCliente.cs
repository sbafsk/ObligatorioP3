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
            Cliente cli = null;

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Cliente where Id=@id;";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    cli = new Cliente
                    {
                        Id = reader.GetInt32(0),                        
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Cedula = reader.GetString(3),
                        RUT = reader.GetString(4),
                        FechaCreacion = reader.GetDateTime(5)
                    };
                }

                con.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return cli;
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
