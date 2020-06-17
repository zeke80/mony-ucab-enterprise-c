using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OperacionCuentaDTO
    {
		int _Idoperacioncuenta;
		int _Idcuenta;
		int _IdUsuarioReceptor;
		DateTime _Fecha;
		TimeSpan _Hora;
		float _Monto;
		string _Referencia;

        public int Idoperacioncuenta { get => _Idoperacioncuenta; set => _Idoperacioncuenta = value; }
        public int Idcuenta { get => _Idcuenta; set => _Idcuenta = value; }
        public int IdUsuarioReceptor { get => _IdUsuarioReceptor; set => _IdUsuarioReceptor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public TimeSpan Hora { get => _Hora; set => _Hora = value; }
        public float Monto { get => _Monto; set => _Monto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
    }
}