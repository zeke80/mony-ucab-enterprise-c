using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonyUCAB.Models
{
    public class InfoUsuario
    {
        public int idUsuario { get; set; }
        public string user { get; set; }
        public int di { get; set; }
        public string email { get; set; }
        public string telf { get; set; }
        public string dir { get; set; }
    }
}
