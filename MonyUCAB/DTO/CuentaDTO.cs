using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class CuentaDTO
    {
        int Idcuenta;
        int Idusuario;
        int Idtipocuenta;
        int Idbanco;
        string Numero;

        public int Idcuenta1 { get => Idcuenta; set => Idcuenta = value; }
        public int Idusuario1 { get => Idusuario; set => Idusuario = value; }
        public int Idtipocuenta1 { get => Idtipocuenta; set => Idtipocuenta = value; }
        public int Idbanco1 { get => Idbanco; set => Idbanco = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
    }
}