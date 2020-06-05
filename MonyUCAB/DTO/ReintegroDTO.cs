using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class ReintegroDTO
    {
		int _Idreintegro;
		int _Idusuario_solicitante;
		int _Idusuario_receptor;
		string _Fecha_solicitud;
		string _Referencia;
		string _Estatus;

        public int Idreintegro { get => _Idreintegro; set => _Idreintegro = value; }
        public int Idusuario_solicitante { get => _Idusuario_solicitante; set => _Idusuario_solicitante = value; }
        public int Idusuario_receptor { get => _Idusuario_receptor; set => _Idusuario_receptor = value; }
        public string Fecha_solicitud { get => _Fecha_solicitud; set => _Fecha_solicitud = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
    }
}