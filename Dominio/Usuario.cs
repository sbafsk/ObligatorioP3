﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Cedula { get; set; }

        public string Contraseña { get; set; }

        public string Rol { get; set; }
    }
}
