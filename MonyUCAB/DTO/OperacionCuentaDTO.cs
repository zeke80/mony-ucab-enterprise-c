﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class OperacionCuentaDTO
    {
		int _Idoperacioncuenta;
		int _Idcuenta;
		int _Idusuarioreceptor;
		DateTime _Fecha;
		DateTime _Hora;
		float _Monto;
		string _Referencia;

        public int Idoperacioncuenta { get => _Idoperacioncuenta; set => _Idoperacioncuenta = value; }
        public int Idcuenta { get => _Idcuenta; set => _Idcuenta = value; }
        public int Idusuarioreceptor { get => _Idusuarioreceptor; set => _Idusuarioreceptor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public DateTime Hora { get => _Hora; set => _Hora = value; }
        public float Monto { get => _Monto; set => _Monto = value; }
        public string Referencia { get => _Referencia; set => _Referencia = value; }
    }
}