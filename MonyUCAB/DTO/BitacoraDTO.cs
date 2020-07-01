using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class BitacoraDTO
    {
		int _Idauditoria;
		int _Idevento;
		int _Idusuario;
		DateTime _Fecha;
		DateTime _Hora;
		string _Datos_operacion;
		string _Causa_error;

        public int Idauditoria { get => _Idauditoria; set => _Idauditoria = value; }
        public int Idevento { get => _Idevento; set => _Idevento = value; }
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public DateTime Hora { get => _Hora; set => _Hora = value; }
        public string Datos_operacion { get => _Datos_operacion; set => _Datos_operacion = value; }
        public string Causa_error { get => _Causa_error; set => _Causa_error = value; }
    }
}