using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebMVC.ViewModels

{
    public class ViewModelUsuario
    {
        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [Required]
        public string Rol { get; set; }
    }
}