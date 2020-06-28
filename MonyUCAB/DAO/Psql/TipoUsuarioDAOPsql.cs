using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class TipoUsuarioDAOPsql : DAOPsql, ITipoUsuarioDAO
    {
        public void RegistrarTipoUsuario(string descripcion )
        {
            comando.CommandText = string.Format(
                "INSERT INTO tipousuario(" +
                "descripcion," +
                "estatus" +
                ") VALUES('{0}',1)", descripcion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        
        }

    }
}