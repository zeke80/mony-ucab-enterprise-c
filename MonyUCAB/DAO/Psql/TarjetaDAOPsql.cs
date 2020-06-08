using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class TarjetaDAOPsql : DAOPsql, ITarjetaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public List<TarjetaDTO> buscar(int idUsuario)
        {
            comando.CommandText = string.Format("SELECT " +
                "idtarjeta," +
                "idusuario," +
                "idtipotarjeta," +
                "idbanco," +
                "numero," +
                "fecha_vencimiento," +
                "cvc," +
                "estatus " +
                "FROM tarjeta " +
                "WHERE idusuario = {0}", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            List<TarjetaDTO> listaTarjeta = new List<TarjetaDTO>();
            while (filas.Read())
            {
                listaTarjeta.Add(new TarjetaDTO
                {
                    Idtarjeta = filas.GetInt32(0),
                    Idusuario = filas.GetInt32(1),
                    Idtipotarjeta = filas.GetInt32(2),
                    Idbanco = filas.GetInt32(3),
                    Numero = filas.GetInt32(4),
                    Fecha_vencimiento = filas.GetDateTime(5),
                    Cvc = filas.GetInt32(6),
                    Estatus = filas.GetInt32(7),
                });
            }
            filas.Close();
            conexion.Close();
            return listaTarjeta;
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