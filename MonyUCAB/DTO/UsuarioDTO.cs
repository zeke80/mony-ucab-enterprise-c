using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DTO
{
    public class UsuarioDTO
    {
		int _Idusuario;
		int _Idtipousuario;
		int _Idtipoidentificacion;
		string _Usuario;
		DateTime _Fecha_registro;
		int _Nro_identificacion;
		string _Email;
		string _Telefono;
		string _Direccion;
		int _Estatus;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idtipousuario { get => _Idtipousuario; set => _Idtipousuario = value; }
        public int Idtipoidentificacion { get => _Idtipoidentificacion; set => _Idtipoidentificacion = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public DateTime Fecha_registro { get => _Fecha_registro; set => _Fecha_registro = value; }
        public int Nro_identificacion { get => _Nro_identificacion; set => _Nro_identificacion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int Estatus { get => _Estatus; set => _Estatus = value; }
    }
}