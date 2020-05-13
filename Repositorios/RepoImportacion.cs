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
    public class RepoImportacion : IRepositorio<Importacion>
    {
        public bool Alta(Importacion obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(int id)
        {
            throw new NotImplementedException();
        }

        public Importacion BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Importacion> ListarTodo()
        {
            List<Importacion> importaciones = new List<Importacion>();

            string strCon = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=PortLogDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(strCon);

            string sql = "select * from Importacion";
            SqlCommand com = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                RepoProducto repo_prod = new RepoProducto();

                //Producto prd = new Producto();

                while (reader.Read())
                {

                    Importacion importacion = new Importacion
                    {
                        Id = reader.GetInt32(0),
                        FechaIngreso = reader.GetDateTime(1),
                        FechaPrevSalida = reader.GetDateTime(2),
                        FechaSalida = reader.GetDateTime(3),
                        Producto = repo_prod.BuscarPorId(reader.GetInt32(4)),
                        CantidadUnidades = reader.GetInt32(5),
                        PrecioUnitario = reader.GetInt32(6),

                    };

                    importaciones.Add(importacion);
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

            return importaciones;
        }

        public bool Modificacion(Importacion obj)
        {
            throw new NotImplementedException();
        }
    }
}
