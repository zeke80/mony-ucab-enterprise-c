using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OperacionTarjetaDTO
    {
		int Idoperaciontarjeta;
		int Idusuarioreceptor;
		int Idtarjeta;
		DateTime Fecha;
		DateTime Hora;
		float Monto;
		string Referencia;

        public int Idoperaciontarjeta1 { get => Idoperaciontarjeta; set => Idoperaciontarjeta = value; }
        public int Idusuarioreceptor1 { get => Idusuarioreceptor; set => Idusuarioreceptor = value; }
        public int Idtarjeta1 { get => Idtarjeta; set => Idtarjeta = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public float Monto1 { get => Monto; set => Monto = value; }
        public string Referencia1 { get => Referencia; set => Referencia = value; }
    }
}