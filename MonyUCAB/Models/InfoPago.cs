using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoPago
    {
        public int idUsuarioSolicitante { get; set; }
        public string userReceptor { get; set; }
        public float monto { get; set; }
    }
}
