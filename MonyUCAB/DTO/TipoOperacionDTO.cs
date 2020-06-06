using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TipoOperacionDTO
    {
        int _Idtipooperacion;
        string _Descripcion;
        int _Estatus;

        public int Idtipooperacion { get => _Idtipooperacion; set => _Idtipooperacion = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}