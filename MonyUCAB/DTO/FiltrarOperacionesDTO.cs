using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class FiltrarOperacionesDTO
    {
        DateTime _Fecha;
        TimeSpan _Hora ;
        int _Monto;
        int _Referencia;

        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public TimeSpan Hora{ get => _Hora; set => _Hora = value; }
        public int Monto { get => _Monto; set => _Monto = value; }
        public int Referencia { get => _Referencia; set => _Referencia = value; }
    }
}