using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TarjetaDTO
    {
		int Idtarjeta;
		int Idusuario;
		int Idtipotarjeta;
		int Idbanco;
		int Numero;
		DateTime Fecha_vencimiento;
		int Cvc;
		int Estatus;

        public int Idtarjeta1 { get => Idtarjeta; set => Idtarjeta = value; }
        public int Idusuario1 { get => Idusuario; set => Idusuario = value; }
        public int Idtipotarjeta1 { get => Idtipotarjeta; set => Idtipotarjeta = value; }
        public int Idbanco1 { get => Idbanco; set => Idbanco = value; }
        public int Numero1 { get => Numero; set => Numero = value; }
        public DateTime Fecha_vencimiento1 { get => Fecha_vencimiento; set => Fecha_vencimiento = value; }
        public int Cvc1 { get => Cvc; set => Cvc = value; }
        public int Estatus1 { get => Estatus; set => Estatus = value; }
    }
}