using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class CuentaDAOPsql : DAOPsql, ICuentaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public CuentaDTO buscarCuenta(int idCuenta)
        {
            comando.CommandText = string.Format("SELECT " +
                "idcuenta," +
                "idusuario," +
                "idtipocuenta," +
                "idbanco," +
                "numero " +
                "FROM cuenta " +
                "WHERE idcuenta = {0}", idCuenta);
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
            conexion.Close();
            return cuentaDTO;
        }

        public List<CuentaDTO> buscarCuentas(int idUsuario)
        {
            comando.CommandText = string.Format("SELECT " +
                "idcuenta," +
                "idusuario," +
                "idtipocuenta," +
                "idbanco," +
                "numero " +
                "FROM cuenta " +
                "WHERE idusuario = {0}", idUsuario);
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
            conexion.Close();
            return cuentaDTOs;
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void registrarCuenta(int idUsuario, int idtipocuenta, int idbanco, string numero)
        {
            comando.CommandText = string.Format(
                "INSERT INTO cuenta(" +
                    "idusuario, " +
                    "idtipocuenta, " +
                    "idbanco, " +
                    "numero " +   
                ") " +
                "values" +
                "({0}, {1}, {2}, '{3}')",idUsuario, idtipocuenta, idbanco, numero);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

         public void registrarTipocuenta(string descripcion)
        {
            comando.CommandText = string.Format(
                "INSERT INTO tipocuenta(" +
                    "descripcion," +
                    "estatus" +  
                ") " +
                "values" +
                "('{0}',1)",descripcion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}