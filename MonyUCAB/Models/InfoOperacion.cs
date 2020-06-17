using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoOperacion
    {
        public int idUsuarioSolicitante { get; set; }
        public int idUsuarioReceptor { get; set; }
        public string referencia { get; set; }
    }
}
