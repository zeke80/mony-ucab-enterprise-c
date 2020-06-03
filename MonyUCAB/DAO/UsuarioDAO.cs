using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;

namespace MonyUCAB.DAO
{
    public class UsuarioDAO : ConexionBD
    {
        public List<UsuarioDTO> consultar()
        {
            comando.CommandText = "SELECT " +
                "idusuario," +
                "idtipousuario," +
                "idtipoidentificacion," +
                "usuario,fecha_registro," +
                "nro_identificacion,email," +
                "telefono,direccion," +
                "estatus " +
                "FROM usuario";
            conexion.Open();
            leerFilas = comando.ExecuteReader();
            List<UsuarioDTO> listaUsuarios = new List<UsuarioDTO>();
            while (leerFilas.Read())
            {
                listaUsuarios.Add(new UsuarioDTO
                {
                    Idusuario = leerFilas.GetInt32(0),
                    Idtipousuario = leerFilas.GetInt32(1),
                    Idtipoidentificacion = leerFilas.GetInt32(2),
                    Usuario = leerFilas.GetString(3),
                    Fecha_registro = leerFilas.GetDateTime(4),
                    Nro_identificacion = leerFilas.GetInt32(5),
                    Email = leerFilas.GetString(6),
                    Telefono = leerFilas.GetString(7),
                    Direccion = leerFilas.GetString(8),
                    Estatus = leerFilas.GetInt32(9),
                });
            }
            leerFilas.Close();
            conexion.Close();
            return listaUsuarios;
        }
        public void insertar(){}
        public void editar(){}
        public void eliminar(){}
    }
}