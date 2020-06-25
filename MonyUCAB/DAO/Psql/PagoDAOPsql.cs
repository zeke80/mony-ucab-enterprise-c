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
    public class PagoDAOPsql : DAOPsql, IPagoDAO
    {
        public List<PagoDTO> pagosSolicitadosSolicitante(int idUsuarioSolicitante)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "pagosSolicitadosSolicitante({0})", idUsuarioSolicitante);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<PagoDTO> operacionPagoDTOs = new List<PagoDTO>();
                while (filas.Read())
                {
                    operacionPagoDTOs.Add(new PagoDTO
                    {
                        Idpago = filas.GetInt32(0),
                        Idusuario_solicitante = filas.GetInt32(1),
                        Idusuario_receptor = filas.GetInt32(2),
                        Fecha_solicitus = filas.GetDateTime(3),
                        Monto = filas.GetFloat(4),
                        Estatus = filas.GetString(5),
                        Referencia = filas.GetInt32(6),
                    });
                }
                filas.Close();
                return operacionPagoDTOs;
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

        public List<PagoDTO> pagosSolicitadosReceptor(int idUsuarioReceptor)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "pagosSolicitadosReceptor({0})", idUsuarioReceptor);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<PagoDTO> operacionPagoDTOs = new List<PagoDTO>();
                while (filas.Read())
                {
                    operacionPagoDTOs.Add(new PagoDTO
                    {
                        Idpago = filas.GetInt32(0),
                        Idusuario_solicitante = filas.GetInt32(1),
                        Idusuario_receptor = filas.GetInt32(2),
                        Fecha_solicitus = filas.GetDateTime(3),
                        Monto = filas.GetFloat(4),
                        Estatus = filas.GetString(5),
                        Referencia = filas.GetInt32(6),
                    });
                }
                filas.Close();
                return operacionPagoDTOs;
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

        public int solicitar(int idUsuarioSolicitante, string userReceptor, float monto)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "PagoDAOPsqlsolicitar( {0}, '{1}', {2}",
                idUsuarioSolicitante, userReceptor, monto);
                conexion.Open();
                int idPago = (int)comando.ExecuteScalar();
                return idPago;
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

        public decimal saldo(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format(
                    "SELECT coalesce(SUM(opemon.mo), 0) " +
                    "FROM " +
                    "( " +
                            "SELECT monto mo, idusuario, referencia " +
                            "FROM operacionesmonedero " +
                            "WHERE idtipooperacion = 1 " +
                        "UNION ALL " +
                            "SELECT -monto mo, idusuario, referencia " +
                            "FROM operacionesmonedero " +
                            "WHERE idtipooperacion = 2 " +
                    ") opemon, pago pag " +
                    "WHERE opemon.idusuario = {0} " +
                    "AND pag.referencia = opemon.referencia " +
                    "AND pag.estatus = 'PAGADO'", idUsuario);
                conexion.Open();
                decimal saldo = (decimal)comando.ExecuteScalar();
                return saldo;
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

        public void actualizarSolicitudPagada(int referencia)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "actualizarSolicitudPagada( '{0}')", referencia);
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

        public void actualizarPagoReintegrado(int idReintegro)
        {
            try
            {
                comando.CommandText = string.Format("SELECT" + 
                "actualizarPagoReintegrado({0})", idReintegro);
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

        public List<PagoDTO> cierre(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format(
                    "SELECT " +
                        "idpago, " +
                        "idusuario_solicitante, " +
                        "idusuario_receptor, " +
                        "fecha_solicitus, " +
                        "monto, " +
                        "estatus, " +
                        "referencia " +
                    "FROM pago " +
                    "WHERE(idusuario_solicitante = {0} " +
                    "OR idusuario_receptor = {0}) " +
                    "AND fecha_solicitus = DATE_TRUNC('day', now())",
                    idUsuario);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<PagoDTO> pagoDTOs = new List<PagoDTO>();
                while (filas.Read())
                {
                    pagoDTOs.Add(new PagoDTO
                    {
                        Idpago = filas.GetInt32(0),
                        Idusuario_solicitante = filas.GetInt32(1),
                        Idusuario_receptor = filas.GetInt32(2),
                        Fecha_solicitus = filas.GetDateTime(3),
                        Monto = filas.GetFloat(4),
                        Estatus = filas.GetString(5),
                        Referencia = filas.GetInt32(6),
                    });
                }
                filas.Close();
                return pagoDTOs;
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