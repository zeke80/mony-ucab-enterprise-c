using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class UsuarioOpcionMenuDTO
    {
        int _Idusuario;
        int _Idopcionmenu;
        int _Estatus;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idopcionmenu { get => _Idopcionmenu; set => _Idopcionmenu = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}