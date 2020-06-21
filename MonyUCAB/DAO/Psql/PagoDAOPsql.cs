using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class PagoDAOPsql : DAOPsql, IPagoDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public List<PagoDTO> buscar()
        {
            throw new NotImplementedException();
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public List<PagoDTO> pagosSolicitadosSolicitante(int idUsuarioSolicitante)
        {
            comando.CommandText = string.Format(
            "SELECT " +
            "idpago," +
            "idusuario_solicitante," +
            "idusuario_receptor," +
            "fecha_solicitus," +
            "monto," +
            "estatus," +
            "referencia " +
            "FROM pago " +
            "WHERE idusuario_solicitante = {0} AND estatus = 'SOLICITADO' " +
            "ORDER BY idpago DESC", idUsuarioSolicitante);
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
                    Fecha_solicitus = filas.GetString(3),
                    Monto = filas.GetFloat(4),
                    Estatus = filas.GetString(5),
                    Referencia = filas.GetInt32(6),
                });
            }
            filas.Close();
            conexion.Close();
            return operacionPagoDTOs;
        }

        public List<PagoDTO> pagosSolicitadosReceptor(int idUsuarioReceptor)
        {
            comando.CommandText = string.Format(
            "SELECT " +
            "idpago," +
            "idusuario_solicitante," +
            "idusuario_receptor," +
            "fecha_solicitus," +
            "monto," +
            "estatus," +
            "referencia " +
            "FROM pago " +
            "WHERE idusuario_receptor = {0} AND estatus = 'SOLICITADO' " +
            "ORDER BY idpago DESC", idUsuarioReceptor);
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
                    Fecha_solicitus = filas.GetString(3),
                    Monto = filas.GetFloat(4),
                    Estatus = filas.GetString(5),
                    Referencia = filas.GetInt32(6),
                });
            }
            filas.Close();
            conexion.Close();
            return operacionPagoDTOs;
        }

        public int solicitar(int idUsuarioSolicitante, string userReceptor, float monto)
        {
            comando.CommandText = string.Format(
                "insert into pago(" +
                    "idusuario_solicitante," +
                    "idusuario_receptor," +
                    "fecha_solicitus," +
                    "monto," +
                    "estatus" +
                ") " +
                "values" +
                "({0}, (SELECT us.idusuario FROM usuario us WHERE us.usuario = '{1}'), '{2}', {3}, 'SOLICITADO') " +
                "RETURNING idpago",
                idUsuarioSolicitante, userReceptor, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), monto);
            conexion.Open();
            int idPago = (int)comando.ExecuteScalar();
            conexion.Close();
            return idPago;
        }

        public decimal saldo(int idUsuario)
        {
            comando.CommandText = string.Format(
                "SELECT SUM(opemon.mo) " +
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
            conexion.Close();
            return saldo;
        }

        public void actualizarSolicitudPagada(int referencia)
        {
            comando.CommandText = string.Format("update pago set estatus = 'PAGADO' where referencia = {0}", referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void actualizarPagoReintegrado(int idReintegro)
        {
            comando.CommandText = string.Format(
                "UPDATE pago SET " +
                "estatus = 'REINTEGRADO' " +
                "WHERE referencia = (SELECT referencia FROM reintegro WHERE idreintegro = {0})", idReintegro);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}