using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.ViewModels;
using Dominio;
using Repositorios;
using System.Text.RegularExpressions;

namespace WebMVC.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult RegistroUsuario(string Msg = "")
        {
            if(Session["rolUsuario"].ToString() == "admin")
            {
                ViewBag.Message = Msg;
                return View();
            } else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult ValidarRegistroUsuario(Usuario user)
        {

            String[] rols = { "admin", "deposito" };

            String msg = "";

            if (rols.Contains(user.Rol) && 
                Usuario.ValidarCedula(user.Cedula) &&
                Usuario.ValidarContraseña(user.Contraseña))
            {
                RepoUsuario repo = new RepoUsuario();                

                if (repo.ValidarUsuario(user.Cedula, user.Contraseña) != null)
                {
                    msg = "Ya existe un usuario con esa CI.";
                }
                else
                {                   

                    if (repo.Alta(user))
                    {
                        msg = "Usuario creado exitosamente.";                        

                    }
                    else
                    {
                        msg = "Hubo un error no se pudo crear el usuario.";
                    }
                }
            } else
            {
                msg = "Los datos debe cumplir con los requisitos solicitados.";
            }
            
            return RedirectToAction("RegistroUsuario", new { Msg = msg});

            
        }

        public ActionResult GenerarTxt()
        {
            if (Session["rolUsuario"].ToString() == "admin")
            {
                
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        

    }
}