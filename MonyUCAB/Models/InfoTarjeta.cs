using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoTarjeta
    {
        public int numero{get; set;}
        public string fecha_vencimiento{get; set;}
        public int cvc {get; set;}
        public string tipotarjeta{get; set;}
        public string banco{get; set;}
        public string user {get; set;}
    }
}
