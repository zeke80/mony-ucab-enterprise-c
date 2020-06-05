using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TipoIdentificacionDTO
    {
        int _Idtipoidentificacion;
        string _Codigo;
        string _Descripcion;
        int _Estatus;

        public int Idtipoidentificacion { get => _Idtipoidentificacion; set => _Idtipoidentificacion = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}