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
    public class ImportacionController : Controller
    {
        // GET: Importacion
        public ActionResult AltaImportacion()
        {
            return View();
        }

        public ActionResult CalculoGanancia()
        {
            return View();
        }
    }
}