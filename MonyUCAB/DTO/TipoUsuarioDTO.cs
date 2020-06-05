using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TipoUsuarioDTO
    {
        int _Idtipousuario;
        string _Descripcion;
        int _Estatus;

        public int Idtipousuario { get => _Idtipousuario; set => _Idtipousuario = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}