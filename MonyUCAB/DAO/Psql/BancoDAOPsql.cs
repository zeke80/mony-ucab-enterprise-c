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
    public class BancoDAOPsql : DAOPsql, IBancoDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public List<BancoDTO> buscar()
        {
            throw new NotImplementedException();
        }

        public BancoDTO buscarIdbanco(string nombre)
        {
            try
            {
                comando.CommandText = string.Format("SELECT " +
                    "ba.idbanco " +
                    "FROM banco ba, cuenta cu, usuario us, tipocuenta ti " +
                    "WHERE us.idusuario = cu.idusuario " +
                    "AND cu.idtipocuenta = ti.idtipocuenta " +
                    "AND ba.nombre = '{0}' " +
                    "order by ba.idbanco desc " +
                    "limit 1", nombre);
                conexion.Open();
                filas = comando.ExecuteReader();
                BancoDTO bancoDTO = null;
                if (filas.Read())
                {
                    bancoDTO = new BancoDTO
                    {
                        IdBanco = filas.GetInt32(0),
                    };
                }
                filas.Close();
                return bancoDTO;
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

        public void registrarBanco(string nombre, int estatus)
        {
            try
            {
                comando.CommandText = string.Format(
                    "INSERT INTO banco(" +
                        "nombre, " +
                        "estatus " +
                    ") " +
                    "values" +
                    "('{0}', {1} )", nombre, estatus);
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