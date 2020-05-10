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
    public class RepoUsuario : IRepositorio<Usuario>
    {
        public bool Alta(Usuario obj)
        {
            bool ret = false;
            
            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "insert into Clientes(Cedula, Contraseña , Rol) values(@ci, @psw, @rol);";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@ci", obj.Cedula);
            com.Parameters.AddWithValue("@psw", obj.Contraseña);
            com.Parameters.AddWithValue("@rol", obj.Rol);

            try
            {
                con.Open();
                int afectadas = com.ExecuteNonQuery();
                con.Close();

                ret = afectadas == 1;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return ret;
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            Usuario user = null;

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Usuario where Id=@id;";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    user = new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Cedula = reader.GetString(1),
                        Contraseña = reader.GetString(2),
                        Rol = reader.GetString(3)                        
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

            return user;
        }

        public static bool ValidarUsuario(string cedula, string contraseña)
        {
            bool retorno = false;

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Usuario where Cedula=@user Contraseña=@pass;";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@user", cedula);
            com.Parameters.AddWithValue("@pass", contraseña);

            try
            {
                con.Open();

                int filasAfectadas = com.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
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

            return retorno;
        }

        public List<Usuario> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Modificacion(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
