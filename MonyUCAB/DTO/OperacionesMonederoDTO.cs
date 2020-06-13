using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OperacionesMonederoDTO
    {
		int _Idoperacionesmonedero;
		int _Idusuario;
		int _Idtipooperacion;
		float _Monto;
		DateTime _Fecha;
		TimeSpan _Hora;
		string _Referencia;

        public int Idoperacionesmonedero { get => _Idoperacionesmonedero; set => _Idoperacionesmonedero = value; }
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idtipooperacion { get => _Idtipooperacion; set => _Idtipooperacion = value; }
        public float Monto { get => _Monto; set => _Monto = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public TimeSpan Hora { get => _Hora; set => _Hora = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
    }
}