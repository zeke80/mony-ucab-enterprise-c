using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class EventoDTO
    {
        int _Idevento;
        string _Codigo_evento;
        string _Evento;
        int _Estatus;

        public int Idevento { get => _Idevento; set => _Idevento = value; }
        public string Codigo_evento { get => _Codigo_evento; set => _Codigo_evento = value; }
        public string Evento { get => _Evento; set => _Evento = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}