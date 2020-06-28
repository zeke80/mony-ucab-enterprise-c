using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class TipoIdentificacionDAOPsql : DAOPsql, ITipoIdentificacionDAO
    {

        public void RegistrarTipoIdentificacion(string descripcion )
        {
            comando.CommandText = string.Format(
                "INSERT INTO tipoidentificacion(" +
                "codigo, " +
                "descripcion, " +
                "estatus " +
                ") VALUES ( 1,'{0}', 1)", descripcion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        
        }
        
    }
}