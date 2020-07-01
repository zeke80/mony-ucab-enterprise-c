using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OpcionMenuDTO
    {
		int _Idopcionmenu;
		int _Idaplicacion;
		string _Nombre;
		string _Descripcion;
		string _Url;
		int _Posicion;
		string _Estatus;

        public int Idopcionmenu { get => _Idopcionmenu; set => _Idopcionmenu = value; }
        public int Idaplicacion { get => _Idaplicacion; set => _Idaplicacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Url { get => _Url; set => _Url = value; }
        public int Posicion { get => _Posicion; set => _Posicion = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
    }
}