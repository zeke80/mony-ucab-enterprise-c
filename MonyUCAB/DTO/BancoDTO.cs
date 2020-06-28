using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class BancoDTO
    {
        int _IdBanco;
        string _Nombre;
        int _Estatus;

        public int IdBanco { get => _IdBanco; set => _IdBanco = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}