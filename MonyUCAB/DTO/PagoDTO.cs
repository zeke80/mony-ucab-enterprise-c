using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class PagoDTO
    {
        int _Idpago;
        int _Idusuario_solicitante;
        int _Idusuario_receptor;
        string _Fecha_solicitus;
        string _Monto;
        string _Estatus;
        int _Referencia;

        public int Idpago { get => _Idpago; set => _Idpago = value; }
        public int Idusuario_solicitante { get => _Idusuario_solicitante; set => _Idusuario_solicitante = value; }
        public int Idusuario_receptor { get => _Idusuario_receptor; set => _Idusuario_receptor = value; }
        public string Fecha_solicitus { get => _Fecha_solicitus; set => _Fecha_solicitus = value; }
        public string Monto { get => _Monto; set => _Monto = value; }
        public string Estatus { get => _Estatus; set => _Estatus = value; }
        public int Referencia { get => _Referencia; set => _Referencia = value; }
    }
}