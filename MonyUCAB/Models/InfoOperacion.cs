using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoOperacion
    {
        public int idOrigen { get; set; }
        public string usuarioReceptor { get; set; }
        public float monto { get; set; }
        public int referencia { get; set; }
    }
}
