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

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaPrevSalida { get; set; }

        public DateTime FechaSalida { get; set; }

        public Producto Producto { get; set; }

        public int CantidadUnidades { get; set; }

        public int PrecioUnitario { get; set; }

        
    }
}
