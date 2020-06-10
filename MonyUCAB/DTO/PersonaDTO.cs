using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class PersonaDTO
    {
        int _Idusuario;
        int _Idestadocivil;
        string _Nombre;
        string _Apellido;
        DateTime _Fecha_nacimiento;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idestadocivil { get => _Idestadocivil; set => _Idestadocivil = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
    }
}