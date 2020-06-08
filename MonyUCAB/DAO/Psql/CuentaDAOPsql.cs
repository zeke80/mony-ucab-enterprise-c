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

        public List<CuentaDTO> buscar(int idUsuario)
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
            List<CuentaDTO> listaCuenta = new List<CuentaDTO>();
            while (filas.Read())
            {
                listaCuenta.Add(new CuentaDTO
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
            return listaCuenta;
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