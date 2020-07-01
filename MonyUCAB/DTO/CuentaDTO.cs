using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class CuentaDTO
    {
        int _Idcuenta;
        int _Idusuario;
        int _Idtipocuenta;
        int _Idbanco;
        string _Numero;

        public int Idcuenta { get => _Idcuenta; set => _Idcuenta = value; }
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idtipocuenta { get => _Idtipocuenta; set => _Idtipocuenta = value; }
        public int Idbanco { get => _Idbanco; set => _Idbanco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
    }
}