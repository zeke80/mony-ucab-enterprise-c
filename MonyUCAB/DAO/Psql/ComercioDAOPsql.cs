using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using System.Runtime.InteropServices.WindowsRuntime;
using Npgsql;

namespace MonyUCAB.DAO
{
    public class ComercioDAOPsql : DAOPsql, IComercioDAO
    {
        public void ajustar(int idUsuario, string razonSocial, string nombre, string apellido)
        {
            try
            {
                comando.CommandText = string.Format("SELECT ComercioDAOPsqlAjustar( {3}, '{0}', '{1}', '{2}')", 
                razonSocial, nombre, apellido, idUsuario);
                conexion.Open();
                comando.ExecuteNonQuery();                
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            finally{
                conexion.Close();
            }
        }

        public ComercioDTO buscar(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM ComercioDAOPsqlbuscar({0})", idUsuario);
                conexion.Open();
                filas = comando.ExecuteReader();
                ComercioDTO comercioDTO = null;
                if (filas.Read())
                {
                    comercioDTO = new ComercioDTO
                    {
                        Idusuario = filas.GetInt32(0),
                        Razon_social = filas.GetString(1),
                        Nombre_representante = filas.GetString(2),
                        Apellido_representante = filas.GetString(3),
                    };
                }
                filas.Close();
                return comercioDTO;
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

        public void registrarComercio(int idusuario,string razon_social, string nombre_representante, string apellido_representante)
        {
            try
            {
                comando.CommandText = string.Format(
                    "INSERT INTO comercio(" +
                        "idusuario," +
                        "razon_social," +
                        "nombre_representante," +
                        "apellido_representante" +
                    ") " +
                    "values" +
                    "({0},'{1}','{2}', '{3}')", idusuario, razon_social, nombre_representante, apellido_representante);
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
