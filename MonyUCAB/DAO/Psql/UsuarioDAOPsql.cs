using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using Microsoft.SqlServer.Server;

namespace MonyUCAB.DAO
{
    public class UsuarioDAOPsql : DAOPsql, IUsuarioDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO buscar(int idUsuario)
        {
            comando.CommandText = string.Format(
            "SELECT " +
                "us.idusuario," + 
                "us.idTipoUsuario," +
                "us.idTipoIdentificacion," +
                "us.usuario," +
                "us.fecha_registro," +
                "us.nro_identificacion," +
                "us.email," +
                "us.telefono," +
                "us.direccion," +
                "us.estatus " +
            "FROM Usuario AS us " +
            "WHERE us.idUsuario = {0}", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            UsuarioDTO usuarioDTO = null;
            if (filas.Read())
            {
                usuarioDTO = new UsuarioDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Idtipousuario = filas.GetInt32(1),
                    Idtipoidentificacion = filas.GetInt32(2),
                    Usuario = filas.GetString(3),
                    Fecha_registro = filas.GetDateTime(4),
                    Nro_identificacion = filas.GetInt32(5),
                    Email = filas.GetString(6),
                    Telefono = filas.GetString(7),
                    Direccion = filas.GetString(8),
                    Estatus = filas.GetInt32(9),
                };
            }
            filas.Close();
            conexion.Close();
            return usuarioDTO;
        }

        public UsuarioDTO buscarPersona(string user, string contra){
            comando.CommandText = string.Format("SELECT " +
                "us.idusuario," +
                "us.idtipousuario," +
                "us.idtipoidentificacion," +
                "us.usuario," +
                "us.fecha_registro," +
                "us.nro_identificacion," +
                "us.email," +
                "us.telefono," +
                "us.direccion," +
                "us.estatus " +
                "FROM usuario us, contrasena co, persona pe " +
                "WHERE us.idusuario = pe.idusuario " +
                "AND us.idusuario = co.idusuario " +
                "AND us.usuario = '{0}' " +
                "AND co.contrasena = '{1}'", user, contra);
            conexion.Open();
            filas = comando.ExecuteReader();
            UsuarioDTO usuarioDTO = null;
            if(filas.Read())
            {
                usuarioDTO = new UsuarioDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Idtipousuario = filas.GetInt32(1),
                    Idtipoidentificacion = filas.GetInt32(2),
                    Usuario = filas.GetString(3),
                    Fecha_registro = filas.GetDateTime(4),
                    Nro_identificacion = filas.GetInt32(5),
                    Email = filas.GetString(6),
                    Telefono = filas.GetString(7),
                    Direccion = filas.GetString(8),
                    Estatus = filas.GetInt32(9),
                };
            }
            filas.Close();
            conexion.Close();
            return usuarioDTO;
        }
        public UsuarioDTO buscarComercio(string user, string contra){
            comando.CommandText = string.Format("SELECT " +
                "us.idusuario," +
                "us.idtipousuario," +
                "us.idtipoidentificacion," +
                "us.usuario," +
                "us.fecha_registro," +
                "us.nro_identificacion," +
                "us.email," +
                "us.telefono," +
                "us.direccion," +
                "us.estatus " +
                "FROM usuario us, contrasena co, comercio com " +
                "WHERE us.idusuario = com.idusuario " +
                "AND us.idusuario = co.idusuario " +
                "AND us.usuario = '{0}' " +
                "AND co.contrasena = '{1}'", user, contra);
            conexion.Open();
            filas = comando.ExecuteReader();
            UsuarioDTO usuarioDTO = null;
            if(filas.Read())
            {
                usuarioDTO = new UsuarioDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Idtipousuario = filas.GetInt32(1),
                    Idtipoidentificacion = filas.GetInt32(2),
                    Usuario = filas.GetString(3),
                    Fecha_registro = filas.GetDateTime(4),
                    Nro_identificacion = filas.GetInt32(5),
                    Email = filas.GetString(6),
                    Telefono = filas.GetString(7),
                    Direccion = filas.GetString(8),
                    Estatus = filas.GetInt32(9),
                };
            }
            filas.Close();
            conexion.Close();
            return usuarioDTO;
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }
    }
}