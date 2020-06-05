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
    public class ComercioDAO : ConexionBD
    {
        public List<ComercioDTO> consultar()
        {
            comando.CommandText = "SELECT " +
                "idusuario," +
                "razon_social," +
                "nombre_representante," +
                "apellido_representante," +
                "FROM usuario";
            conexion.Open();
            leerFilas = comando.ExecuteReader();
            List<ComercioDTO> listaComercios = new List<ComercioDTO>();
            while (leerFilas.Read())
            {
                listaComercios.Add(new ComercioDTO
                {
                Idusuario = leerFilas.GetInt32(0),
                Razon_social = leerFilas.GetString(1),
                Nombre_representante = leerFilas.GetString(2),
                Apellido_representante = leerFilas.GetString(3),
                });
            }
            leerFilas.Close();
            conexion.Close();
            return listaComercios;
        }
       
        public void insertar() { }
        public void editar() { }
        public void eliminar() { }
    }
}
}