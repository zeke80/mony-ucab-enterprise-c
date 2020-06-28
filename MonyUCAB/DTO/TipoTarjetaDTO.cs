using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class TipoTarjetaDTO
    {
        int _IdTipoTarjeta;
        string _Descripcion;
        int _Estatus;

        public int IdTipoTarjeta { get => _IdTipoTarjeta; set => _IdTipoTarjeta = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value;}
        public int Estatus {get => _Estatus; set => _Estatus = value;}
    
    }
}