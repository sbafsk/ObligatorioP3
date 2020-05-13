using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.ViewModels;
using WebMVC.ServiceReference;
using Dominio;
using Repositorios;

namespace WebMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ListarProductos()
        {
            if (Session["usuario"] != null)
            {
                List<ViewModelProducto> vm_productos = new List<ViewModelProducto>();


                ServcioMVCClient proxy = new ServcioMVCClient();

                List<DTOProducto> dto_productos = proxy.ListarProductos().ToList();
                
                foreach(DTOProducto dto_p in dto_productos)
                {
                    ViewModelProducto vm_prod = new ViewModelProducto
                    {
                        Id = dto_p.Id,
                        Codigo = dto_p.Codigo,
                        Nombre = dto_p.Nombre,
                        Stock = dto_p.Stock
                    };

                    vm_productos.Add(vm_prod);
                }

                return View(vm_productos);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            
        }
    }
}