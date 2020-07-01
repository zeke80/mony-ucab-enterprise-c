using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TarjetaDTO
    {
		int _Idtarjeta;
		int _Idusuario;
		int _Idtipotarjeta;
		int _Idbanco;
		string _Numero;
		DateTime _Fecha_vencimiento;
		int _Cvc;
		int _Estatus;

        public int Idtarjeta { get => _Idtarjeta; set => _Idtarjeta = value; }
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idtipotarjeta { get => _Idtipotarjeta; set => _Idtipotarjeta = value; }
        public int Idbanco { get => _Idbanco; set => _Idbanco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public DateTime Fecha_vencimiento { get => _Fecha_vencimiento; set => _Fecha_vencimiento = value; }
        public int Cvc { get => _Cvc; set => _Cvc = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}