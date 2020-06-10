using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MonyUCAB.DAO
{
    public class ComercioDAOPsql : DAOPsql, IComercioDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public ComercioDTO buscar(int idUsuario)
        {
            comando.CommandText = string.Format("SELECT " +
                "com.idusuario," +
                "com.razon_social," +
                "com.nombre_representante," +
                "com.apellido_representante " +
                "FROM comercio com " +
                "WHERE com.idusuario = {0}", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            ComercioDTO comercioDTO = null;
            if(filas.Read())
            {
                comercioDTO = new ComercioDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Razon_social = filas.GetString(1),
                    Nombre_representante = filas.GetString(2),
                    Apellido_representante = filas.GetString(3),
                };
            }
            filas.Close();
            conexion.Close();
            return comercioDTO;
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
