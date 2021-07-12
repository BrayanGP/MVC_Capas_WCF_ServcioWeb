using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Primero
{
    public class DCAlumno
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string primerApellido {get;set;}
        [DataMember]
        public string segundoApellido { get; set; }
        [DataMember]
        public string correo { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        [DataMember]
        public string curp { get; set; }
        [DataMember]
        public Nullable<int> idEstadoOrigen { get; set; }
        [DataMember]
        public Nullable<short> idEstatus { get; set; }
    }
}