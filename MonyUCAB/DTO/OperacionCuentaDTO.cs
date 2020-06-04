using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OperacionCuentaDTO
    {
		int Idoperacioncuenta;
		int Idcuenta;
		int Idusuarioreceptor;
		DateTime Fecha;
		DateTime Hora;
		float Monto;
		string Referencia;

        public int Idoperacioncuenta1 { get => Idoperacioncuenta; set => Idoperacioncuenta = value; }
        public int Idcuenta1 { get => Idcuenta; set => Idcuenta = value; }
        public int Idusuarioreceptor1 { get => Idusuarioreceptor; set => Idusuarioreceptor = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public float Monto1 { get => Monto; set => Monto = value; }
        public string Referencia1 { get => Referencia; set => Referencia = value; }
    }
}