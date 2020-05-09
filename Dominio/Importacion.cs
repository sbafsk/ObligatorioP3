using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Importacion
    {
        public int Id { get; set; }

        public string FechaIngreso { get; set; }

        public string FechaPrevSalida { get; set; }

        public string FechaSalida { get; set; }

        public Producto Producto { get; set; }

        public int CantidadUnidades { get; set; }

        public int PrecioUnitario { get; set; }

        public Importacion() { }
    }
}
