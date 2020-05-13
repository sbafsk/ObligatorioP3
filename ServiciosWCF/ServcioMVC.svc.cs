using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio;
using Repositorios;

namespace ServiciosWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServcioMVC" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServcioMVC.svc or ServcioMVC.svc.cs at the Solution Explorer and start debugging.
    public class ServcioMVC : IServcioMVC
    {
        public void DoWork()
        {
        }

        public List<DTOProducto> ListarProductos()
        {
            List<DTOProducto> dto_productos = new List<DTOProducto>();
            
            RepoProducto repoPrd = new RepoProducto();

            RepoImportacion repoImp = new RepoImportacion();

            List<Producto> productos = repoPrd.ListarTodo();

            List<Importacion> importaciones = repoImp.ListarTodo();

            foreach (Producto p in productos)
            {
                DTOProducto dto_prod = new DTOProducto
                {
                    Id = p.Id,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Stock = 0
                };            

                foreach (Importacion i in importaciones)
                {
                    if(p == i.Producto)
                    {
                        dto_prod.Stock = dto_prod.Stock + i.CantidadUnidades;
                    }
                }

                dto_productos.Add(dto_prod);
            }

            return dto_productos;
        }
    }
}
