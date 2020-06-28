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
                "({0}, (SELECT us.idusuario FROM usuario us WHERE us.usuario = '{1}'), now(), CURRENT_TIMESTAMP, {2}, {3})",
                idCuenta, usuarioReceptor, monto, referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

         public List<OperacionCuentaDTO> FiltrarByFechas(int idusuario,string fechainicio, string fechafinal)
        {
            comando.CommandText = string.Format(
                 "SELECT " +
            "op.fecha, " +
            "op.hora, " + 
            "op.monto, " +
            "op.referencia " + 
            "FROM operacioncuenta op , usuario us, cuenta cu " +
            "WHERE fecha between to_date('{1}','yyyy-MM-dd') and to_date('{2}','yyyy-MM-dd')" + 
            "AND us.idusuario = {0} " +
            "AND us.idusuario = cu.idusuario ", idusuario,fechainicio, fechafinal
                );
            conexion.Open();
            filas = comando.ExecuteReader();
            List<OperacionCuentaDTO> filtrarOperaciones = new List<OperacionCuentaDTO>();
            while (filas.Read())
            {
                filtrarOperaciones.Add (new OperacionCuentaDTO
                {
                    Fecha = filas.GetDateTime(0),
                    Hora = filas.GetTimeSpan(1),
                    Monto = filas.GetInt32(2),
                    Referencia = filas.GetInt32(3),
                });
                    
            }
            filas.Close();
            conexion.Close();
            return filtrarOperaciones;
        }
    }

}