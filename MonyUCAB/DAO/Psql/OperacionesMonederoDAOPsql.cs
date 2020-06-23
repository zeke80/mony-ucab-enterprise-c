using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class OperacionesMonederoDAOPsql : DAOPsql, IOperacionesMonederoDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public OperacionesMonederoDTO buscarOperacionMonedero(int idOperacionMonedero)
        {
            comando.CommandText = string.Format(
                "SELECT " +
                    "opm.idoperacionesmonedero," +
                    "opm.idusuario," +
                    "opm.idtipooperacion," +
                    "opm.monto," +
                    "opm.fecha," +
                    "opm.hora," +
                    "opm.referencia " +
                "FROM operacionesmonedero opm " +
                "WHERE opm.idoperacionesmonedero = {0}", idOperacionMonedero);
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
            conexion.Close();
            return operacionesMonederoDTO;
        }

        public List<OperacionesMonederoDTO> buscarOperacionesMonedero(int idUsuario)
        {
            comando.CommandText = string.Format(
                "SELECT " +
                    "opm.idoperacionesmonedero," +
                    "opm.idusuario," +
                    "opm.idtipooperacion," +
                    "opm.monto," +
                    "opm.fecha," +
                    "opm.hora," +
                    "opm.referencia " +
                "FROM operacionesmonedero opm " +
                "WHERE opm.idusuario = {0} " +
                "ORDER BY idoperacionesmonedero DESC", idUsuario);
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
            conexion.Close();
            return operacionesMonederoDTOs;
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void registrarOperacionMonederoRemitente(int idUsuario, float monto, int referencia)
        {
            comando.CommandText = string.Format(
                "INSERT INTO operacionesmonedero(" +
                    "idusuario," +
                    "idtipooperacion," +
                    "monto," +
                    "fecha," +
                    "hora," +
                    "referencia" +
                ") " +
                "values" +
                "({0}, 2, {1}, now(), CURRENT_TIMESTAMP, {2})",
                idUsuario, monto, referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void registrarOperacionMonederoDestinatario(string usuarioReceptor, float monto, int referencia)
        {
            comando.CommandText = string.Format(
                "INSERT INTO operacionesmonedero(" +
                    "idusuario," +
                    "idtipooperacion," +
                    "monto," +
                    "fecha," +
                    "hora," +
                    "referencia" +
                ") " +
                "values" +
                "((SELECT idusuario FROM usuario WHERE usuario = '{0}'), 1, {1}, now(), CURRENT_TIMESTAMP, {2}) ",
                usuarioReceptor, monto, referencia);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}