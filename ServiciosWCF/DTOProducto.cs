using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServiciosWCF
{
    [DataContract]
    public class DTOProducto
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Stock { get; set; }
    }
}