using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoReintegro
    {
        public int idUsuarioSolicitante { get; set; }
        public int idUsuarioReceptor { get; set; }
        public int referencia { get; set; }
    }
}
