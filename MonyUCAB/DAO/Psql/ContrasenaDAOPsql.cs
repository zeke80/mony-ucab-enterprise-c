using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using Npgsql;



namespace MonyUCAB.DAO.Psql
{
    public class ContrasenaDAOPsql : DAOPsql, IContrasenaDAO
    {
        

        public void registrarContrasena(int idUsuario, string contrasena)
        {
            comando.CommandText = string.Format(
                "INSERT INTO contrasena(" +
                    "idusuario, " +
                    "contrasena, " +
                    "intentos_fallidos," +
                    "estatus" +   
                ") " +
                "values" +
                "({0},'{1}',0,1)",idUsuario, contrasena);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void CambiarPassword(int idusuario, string nuevaPass, string viejaPass)
        {
            comando.CommandText = string.Format(
                "UPDATE contrasena SET " +
                "contrasena = '{0}' " +
                "WHERE idusuario = {1}", nuevaPass, idusuario);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

         public ContrasenaDTO buscarcontrasenavieja(int idusuario)
        {
            try{
            comando.CommandText = string.Format("SELECT " +
            "contrasena " + 
            "FROM contrasena " +
            "WHERE idusuario = {0} ", idusuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            ContrasenaDTO contrasenaDTO = null;
            if (filas.Read())
            {
                contrasenaDTO = new ContrasenaDTO
                {
                    Contrasena = filas.GetString(0),
                };
            }
            filas.Close();
            return contrasenaDTO;
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