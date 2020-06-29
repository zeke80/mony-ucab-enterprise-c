using MonyUCAB.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class CuentaDAOPsql : DAOPsql, ICuentaDAO
    {
        public CuentaDTO buscarCuenta(int idCuenta)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM CuentaDAOPsqlbuscarCuenta({0})", idCuenta);
                conexion.Open();
                filas = comando.ExecuteReader();
                CuentaDTO cuentaDTO = null;
                if (filas.Read())
                {
                    cuentaDTO = new CuentaDTO
                    {
                        Idcuenta = filas.GetInt32(0),
                        Idusuario = filas.GetInt32(1),
                        Idtipocuenta = filas.GetInt32(2),
                        Idbanco = filas.GetInt32(3),
                        Numero = filas.GetString(4),
                    };
                }
                filas.Close();
                return cuentaDTO;
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

        public List<CuentaDTO> buscarCuentas(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM CuentaDAOPsqlbuscarCuentas({0})", idUsuario);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<CuentaDTO> cuentaDTOs = new List<CuentaDTO>();
                while (filas.Read())
                {
                    cuentaDTOs.Add(new CuentaDTO
                    {
                        Idcuenta = filas.GetInt32(0),
                        Idusuario = filas.GetInt32(1),
                        Idtipocuenta = filas.GetInt32(2),
                        Idbanco = filas.GetInt32(3),
                        Numero = filas.GetString(4),
                    });
                }
                filas.Close();
                return cuentaDTOs;
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

        public void registrarCuenta(int idUsuario, int idtipocuenta, int idbanco, string numero)
        {
            try
            {
                comando.CommandText = string.Format(
                    "INSERT INTO cuenta(" +
                        "idusuario, " +
                        "idtipocuenta, " +
                        "idbanco, " +
                        "numero " +
                    ") " +
                    "values" +
                    "({0}, {1}, {2}, '{3}')", idUsuario, idtipocuenta, idbanco, numero);
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

        public void registrarTipocuenta(string descripcion)
        {
            try
            {
                comando.CommandText = string.Format(
                    "INSERT INTO tipocuenta(" +
                        "descripcion," +
                        "estatus" +
                    ") " +
                    "values" +
                    "('{0}',1)", descripcion);
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