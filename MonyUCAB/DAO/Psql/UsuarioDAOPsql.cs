using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using Microsoft.SqlServer.Server;
using Npgsql;

namespace MonyUCAB.DAO
{
    public class UsuarioDAOPsql : DAOPsql, IUsuarioDAO
    {
        public UsuarioDTO buscar(int idUsuario)
        {
            try
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
                return usuarioDTO;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public UsuarioDTO buscarPersona(string user, string contra){
            try
            {
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
                return usuarioDTO;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }
        public UsuarioDTO buscarComercio(string user, string contra){
            try
            {
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
                return usuarioDTO;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public UsuarioDTO buscarPersonabyEmail(string email){
            try
            {
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
                    "WHERE us.email = '{0}'", email);
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
                return usuarioDTO;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public UsuarioDTO buscarUserAndPass(string email){
            try
            {
                comando.CommandText = string.Format("SELECT " +
                    "us.usuario, " +
                    "con.contrasena " +
                    "FROM usuario us, contrasena con " +
                    "WHERE  us.idusuario = con.idusuario " +
                    "and us.email = '{0}' " +
                    "order by con.idcontrasena desc " +
                    "limit 1", email);
                conexion.Open();
                filas = comando.ExecuteReader();
                UsuarioDTO usuarioDTO = null;
                if (filas.Read())
                {
                    usuarioDTO = new UsuarioDTO
                    {
                        Usuario = filas.GetString(0),
                        Contrasena = filas.GetString(1),
                    };
                }
                filas.Close();
                return usuarioDTO;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void RegistrarUser(int idtipousuario, int idtipoidentificacion,
        string usuario, int nro_identificacion, string email, string telefono,
        string direccion, int estatus)
        {
            comando.CommandText = string.Format(
                "INSERT INTO usuario(" +
                "idtipousuario," +
                "idtipoidentificacion," +
                "usuario," +
                "fecha_registro," +
                "nro_identificacion," +
                "email," +
                "telefono," +
                "direccion," +
                "estatus" +
                
                ") VALUES({0},{1},'{2}',{3},'SOLICITADO')", 
                idtipousuario, idtipoidentificacion, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"),
                nro_identificacion,email,telefono,direccion,estatus);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        
        }

        public void ajustar(int idUsuario, string user, int di, string email, string telf, string dir)
        {
            try
            {
                comando.CommandText = string.Format("UPDATE usuario SET " +
                    "usuario = '{0}', " +
                    "nro_identificacion = {1}, " +
                    "email = '{2}', " +
                    "telefono = '{3}', " +
                    "direccion = '{4}' " +
                    "WHERE idusuario = {5}", user, di, email, telf, dir, idUsuario);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}