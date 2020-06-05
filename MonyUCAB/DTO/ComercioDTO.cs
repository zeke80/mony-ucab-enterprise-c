using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class ComercioDTO
    {
        int _Idusuario;
        string _Razon_social;
        string _Nombre_representante;
        string _Apellido_representante;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public string Razon_social { get => _Razon_social; set => _Razon_social = value; }
        public string Nombre_representante { get => _Nombre_representante; set => _Nombre_representante = value; }
        public string Apellido_representante { get => _Apellido_representante; set => _Apellido_representante = value; }
    }
}