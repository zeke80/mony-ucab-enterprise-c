using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class AplicacionDTO
    {
        int _Idaplicacion;
        string _Nombre;
        string _Descripcion;
        string _Estatus;

        public int Idaplicacion { get => _Idaplicacion; set => _Idaplicacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
    }
}