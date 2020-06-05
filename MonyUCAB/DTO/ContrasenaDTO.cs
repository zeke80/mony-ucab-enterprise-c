using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class ContrasenaDTO
    {
        int _Idcontrasena;
        int _Idusuario;
        string _Contrasena;
        int _Intentos_fallidos;
        int _Estatus;

        public int Idcontrasena { get => _Idcontrasena; set => _Idcontrasena = value; }
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public int Intentos_fallidos { get => _Intentos_fallidos; set => _Intentos_fallidos = value; }
        public int Estatus1 { get => _Estatus; set => _Estatus = value; }
    }
}