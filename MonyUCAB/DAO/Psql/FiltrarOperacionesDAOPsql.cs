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
    public class FiltrarOperacionesDAOPsql : DAOPsql, IFiltrarOperacionesDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public List<FiltrarOperacionesDTO> FiltrarByFechas(int idusuario,string fechainicio, string fechafinal)
        {
            try
            {
                comando.CommandText = string.Format(
                "SELECT " +
                "op.fecha, " +
                "op.hora, " +
                "op.monto, " +
                "op.referencia " +
                "FROM operaciontarjeta op, usuario us, tarjeta ta " +
                "WHERE op.fecha between to_date('{1}','yyyy-MM-dd') and to_date('{2}','yyyy-MM-dd') " +
                "AND us.idusuario = {0} " +
                "AND us.idusuario = ta.idusuario " +
                "UNION ALL " +
                "SELECT " +
                "op.fecha, " +
                "op.hora, " +
                "op.monto, " +
                "op.referencia " +
                "FROM operacioncuenta op , usuario us, cuenta cu " +
                "WHERE fecha between to_date('{1}','yyyy-MM-dd') and to_date('{2}','yyyy-MM-dd')" +
                "AND us.idusuario = {0} " +
                "AND us.idusuario = cu.idusuario " +
                "UNION ALL " +
                "SELECT " +
                "op.fecha, " +
                "op.hora, " +
                "op.monto, " +
                "op.referencia " +
                "FROM operacionesmonedero op , usuario us " +
                "WHERE fecha between to_date('{1}','yyyy-MM-dd') and to_date('{2}','yyyy-MM-dd')" +
                "AND us.idusuario = {0} ", idusuario, fechainicio, fechafinal
                    );
                conexion.Open();
                filas = comando.ExecuteReader();
                List<FiltrarOperacionesDTO> filtrarOperaciones = new List<FiltrarOperacionesDTO>();
                while (filas.Read())
                {
                    filtrarOperaciones.Add(new FiltrarOperacionesDTO
                    {
                        Fecha = filas.GetDateTime(0),
                        Hora = filas.GetTimeSpan(1),
                        Monto = filas.GetInt32(2),
                        Referencia = filas.GetInt32(3),
                    });

                }
                filas.Close();
                return filtrarOperaciones;
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