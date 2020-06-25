using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using Npgsql;

namespace MonyUCAB.DAO
{
    public class OperacionesMonederoDAOPsql : DAOPsql, IOperacionesMonederoDAO
    {

        public OperacionesMonederoDTO buscarOperacionMonedero(int idOperacionMonedero)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "buscarOperacionMonedero({0})", idOperacionMonedero);
                conexion.Open();
                filas = comando.ExecuteReader();
                OperacionesMonederoDTO operacionesMonederoDTO = null;
                if (filas.Read())
                {
                    operacionesMonederoDTO = new OperacionesMonederoDTO
                    {
                        Idoperacionesmonedero = filas.GetInt32(0),
                        Idusuario = filas.GetInt32(1),
                        Idtipooperacion = filas.GetInt32(2),
                        Monto = filas.GetFloat(3),
                        Fecha = filas.GetDateTime(4),
                        Hora = filas.GetTimeSpan(5),
                        Referencia = filas.GetInt32(6),
                    };
                }
                filas.Close();
                return operacionesMonederoDTO;
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

        public List<OperacionesMonederoDTO> buscarOperacionesMonedero(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "buscarOperacionesMonederos({0})", idUsuario);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<OperacionesMonederoDTO> operacionesMonederoDTOs = new List<OperacionesMonederoDTO>();
                while (filas.Read())
                {
                    operacionesMonederoDTOs.Add(new OperacionesMonederoDTO
                    {
                        Idoperacionesmonedero = filas.GetInt32(0),
                        Idusuario = filas.GetInt32(1),
                        Idtipooperacion = filas.GetInt32(2),
                        Monto = filas.GetFloat(3),
                        Fecha = filas.GetDateTime(4),
                        Hora = filas.GetTimeSpan(5),
                        Referencia = filas.GetInt32(6),
                    });
                }
                filas.Close();
                return operacionesMonederoDTOs;
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

        public void registrarOperacionMonederoRemitente(int idUsuario, float monto, int referencia)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "registrarOperacionMonederoRemitente({0}, {1}, '{2}')",
                idUsuario, monto, referencia);
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

        public void registrarOperacionMonederoDestinatario(string usuarioReceptor, float monto, int referencia)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "registrarOperacionMonederoDestinatario('{0}', {1}, '{2}')",
                usuarioReceptor, monto, referencia);
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