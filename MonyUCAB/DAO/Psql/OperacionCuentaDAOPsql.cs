using MonyUCAB.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class OperacionCuentaDAOPsql : DAOPsql, IOperacionCuentaDAO
    {
        public OperacionCuentaDTO buscarOperacionCuenta(int idOperacionCuenta)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM buscarOperacionCuenta({0})", idOperacionCuenta);
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
                return operacionCuentaDTO;
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

        public List<OperacionCuentaDTO> buscarOperacionesCuentas(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM buscarOperacionesCuentas({0})", idUsuario);
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
                return operacionCuentaDTOs;
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

        public void realizar(int idCuenta, string usuarioReceptor, float monto, int referencia)
        {
            try
            {
                comando.CommandText = string.Format("SELECT OperacionCuentaDAOPsqlrealizar({0}, '{1}', {2}, {3})",
                idCuenta, usuarioReceptor, monto, referencia);
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