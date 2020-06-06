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

        public List<ComercioDTO> buscar()
        {
            comando.CommandText = "SELECT " +
                "idusuario," +
                "razon_social," +
                "nombre_representante," +
                "apellido_representante," +
                "FROM usuario";
            conexion.Open();
            filas = comando.ExecuteReader();
            List<ComercioDTO> listaComercios = new List<ComercioDTO>();
            while (filas.Read())
            {
                listaComercios.Add(new ComercioDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Razon_social = filas.GetString(1),
                    Nombre_representante = filas.GetString(2),
                    Apellido_representante = filas.GetString(3),
                });
            }
            filas.Close();
            conexion.Close();
            return listaComercios;
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
