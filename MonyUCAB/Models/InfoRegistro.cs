using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoRegistro
    {
        public string usuario{get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contrasena { get; set; }
        public int idtipousuario { get; set; }
        public int idtipoidentificacion { get; set; }
        public string fecha_nacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string tipoidentificacion { get; set; }
        public int idestadocivil { get; set; }
        public int nro_identificacion {get; set;}
        public int estatus {get; set;}
        public int idusuario {get; set;}
        public string descripciontipousuario {get; set;}
        public string descripciontipoidentificacion {get; set;}
        public string  razon_social{get; set;}
        public string nombre_representante{get; set;}
        public string apellido_representante{get; set;}

    }
}