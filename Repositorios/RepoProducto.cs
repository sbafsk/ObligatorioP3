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
    public class RepoProducto : IRepositorio<Producto>
    {
        public bool Alta(Producto obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Producto BuscarPorId(int id)
        {
            Producto prod = null;

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Producto where Id=@id;";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                RepoCliente repo_cli = new RepoCliente();

                if (reader.Read())
                {
                    Cliente cli = repo_cli.BuscarPorId(reader.GetInt32(4));
                    prod = new Producto
                    {
                        Id = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Nombre= reader.GetString(2),
                        PesoPorUnidad = reader.GetInt32(3),
                        Cliente = cli

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

            return prod;
        }

        public List<Producto> ListarTodo()
        {
            List<Producto> productos = new List<Producto>();

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Producto";
            SqlCommand com = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                RepoCliente repo_cli = new RepoCliente();

                while (reader.Read())
                {
                     
                    Producto prod = new Producto
                    {
                        Id = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        PesoPorUnidad = reader.GetInt32(3),
                        Cliente = repo_cli.BuscarPorId(reader.GetInt32(4))
                };

                    productos.Add(prod);
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

            return productos;
        }

        public bool Modificacion(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
