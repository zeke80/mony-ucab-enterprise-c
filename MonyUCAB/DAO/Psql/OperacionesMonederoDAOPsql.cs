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
                    Referencia = filas.GetString(6),
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
                "WHERE opm.idusuario = {0}", idUsuario);
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
                    Referencia = filas.GetString(6),
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
    }
}