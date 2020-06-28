using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class TipoTarjetaDAOPsql : DAOPsql, ITipoTarjetaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public List<TipoTarjetaDTO> buscar()
        {
            throw new NotImplementedException();
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

         public TipoTarjetaDTO buscarIdTipotarjeta(string descripcion){
            comando.CommandText = string.Format("SELECT " +
                "idtipotarjeta " +
                "FROM tipotarjeta " +
                "WHERE  descripcion = '{0}' ",descripcion);
            conexion.Open();
            filas = comando.ExecuteReader();
            TipoTarjetaDTO tipotarjetaDTO = null;
            if(filas.Read())
            {
                tipotarjetaDTO = new TipoTarjetaDTO
                {
                    IdTipoTarjeta = filas.GetInt32(0)
                };
            }
            filas.Close();
            conexion.Close();
            return tipotarjetaDTO;
        }
    }
}