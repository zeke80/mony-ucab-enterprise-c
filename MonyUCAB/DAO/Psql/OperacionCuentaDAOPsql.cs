using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class OperacionCuentaDAOPsql : DAOPsql, IOperacionCuentaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public OperacionCuentaDTO buscarOperacionCuenta(int idOperacionCuenta)
        {
            comando.CommandText = string.Format(
            "SELECT " +
                "opc.idoperacioncuenta," +
                "opc.idcuenta," +
                "opc.IdUsuarioReceptor," +
                "opc.fecha," +
                "opc.hora," +
                "opc.monto," +
                "opc.referencia " +
            "FROM operacioncuenta opc " +
            "WHERE opc.idoperacioncuenta = {0}", idOperacionCuenta);
            conexion.Open();
            filas = comando.ExecuteReader();
            OperacionCuentaDTO operacionCuentaDTO = null;
            if (filas.Read())
            {
                operacionCuentaDTO = new OperacionCuentaDTO
                {
                    Idoperacioncuenta = filas.GetInt32(0),
                    Idcuenta = filas.GetInt32(1),
                    IdUsuarioReceptor = filas.GetInt32(2),
                    Fecha = filas.GetDateTime(3),
                    Hora = filas.GetTimeSpan(4),
                    Monto = filas.GetFloat(5),
                    Referencia = filas.GetInt32(6),
                };
            }
            filas.Close();
            conexion.Close();
            return operacionCuentaDTO;
        }

        public List<OperacionCuentaDTO> buscarOperacionesCuentas(int idUsuario)
        {
            comando.CommandText = string.Format(
            "SELECT " +
                "opc.idoperacioncuenta," +
                "opc.idcuenta," +
                "opc.IdUsuarioReceptor," +
                "opc.fecha," +
                "opc.hora," +
                "opc.monto," +
                "opc.referencia " +
            "FROM cuenta cue, operacioncuenta opc " +
            "WHERE cue.idcuenta = opc.idcuenta " +
            "AND cue.idusuario = {0} " +
            "UNION " +
            "SELECT " +
                "opc.idoperacioncuenta," +
                "opc.idcuenta," +
                "opc.IdUsuarioReceptor," +
                "opc.fecha," +
                "opc.hora," +
                "opc.monto," +
                "opc.referencia " +
            "FROM operacioncuenta opc " +
            "WHERE opc.IdUsuarioReceptor = {0} " +
            "ORDER BY idoperacioncuenta DESC", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            List<OperacionCuentaDTO> operacionCuentaDTOs = new List<OperacionCuentaDTO>();
            while (filas.Read())
            {
                operacionCuentaDTOs.Add(new OperacionCuentaDTO
                {
                    Idoperacioncuenta = filas.GetInt32(0),
                    Idcuenta = filas.GetInt32(1),
                    IdUsuarioReceptor = filas.GetInt32(2),
                    Fecha = filas.GetDateTime(3),
                    Hora = filas.GetTimeSpan(4),
                    Monto = filas.GetFloat(5),
                    Referencia = filas.GetInt32(6),
                });
            }
            filas.Close();
            conexion.Close();
            return operacionCuentaDTOs;
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void realizar(int idCuenta, string usuarioReceptor, float monto, int referencia)
        {
            comando.CommandText = string.Format(
                "insert into operacioncuenta(" +
                    "idcuenta," +
                    "idusuarioreceptor," +
                    "fecha," +
                    "hora," +
                    "monto," +
                    "referencia" +
                ") " +
                "values" +
                "({0}, (SELECT us.idusuario FROM usuario us WHERE us.usuario = '{1}'), to_date('{2}','dd-MM-yyyy'), TO_TIMESTAMP('{3}','HH24:MI:SS'), {4}, {5})",
                idCuenta, usuarioReceptor, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH:mm:ss"), monto.ToString(), referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

            comando.CommandText = string.Format("update pago set estatus = 'PAGADO' where referencia = {0}", referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}