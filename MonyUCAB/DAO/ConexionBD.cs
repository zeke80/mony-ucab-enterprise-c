using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;

namespace MonyUCAB.DAO
{
    public class ConexionBD
    {
        protected string textConexion;
        protected NpgsqlConnection conexion;
        protected NpgsqlCommand comando;
        protected NpgsqlDataReader leerFilas;

        public ConexionBD()
        {
            textConexion = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=MonyUCABBD;";
            conexion = new NpgsqlConnection(textConexion);
            comando = new NpgsqlCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
    }
}