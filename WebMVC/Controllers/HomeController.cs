using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.ViewModels;
using Dominio;
using Repositorios;


namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ValidarLogin(ViewModelUsuario vm_user)
        {
            RepoUsuario repouser = new RepoUsuario();

            Usuario user = repouser.ValidarUsuario(vm_user.Cedula, vm_user.Contraseña);

            if (user != null)
            {
                Session["usuario"] = user;
                Session["rolUsuario"] = user.Rol;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Usuario incorrecto.";
                return View("Login");
            }
        }

        public ActionResult Logout()
        {                       
            Session["usuario"] = null;
            return RedirectToAction("Index");            
            
        }
    }
}