using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;

namespace MonyUCAB.DAO
{
    public class DAOPsql
    {
        protected string textConexion;
        protected NpgsqlConnection conexion;
        protected NpgsqlCommand comando;
        protected NpgsqlDataReader filas;

        public DAOPsql()
        {
            textConexion = "Server=ec2-52-203-160-194.compute-1.amazonaws.com;" +
                "Port=5432;" +
                "User Id=ppaslmipvfumce;" +
                "Password=5daf33bd4e95b74bc2dc0ef64d9b21a2d8fe83b0d602e4db97cca72d5f7627c6;" +
                "Database=d1psqo5qceht6j;" +
                "SSL Mode=Require;" +
                "Trust Server Certificate=true";
            conexion = new NpgsqlConnection(textConexion);
            comando = new NpgsqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
    }
}