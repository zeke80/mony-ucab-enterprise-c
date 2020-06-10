using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class PersonaDAOPsql : DAOPsql, IPersonaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public PersonaDTO buscar(int idUsuario)
        {
            comando.CommandText = string.Format("SELECT " +
                "per.idusuario," +
                "per.idestadocivil," +
                "per.nombre," +
                "per.apellido," +
                "per.fecha_nacimiento " +
                "FROM persona per " +
                "WHERE per.idusuario = {0}", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            PersonaDTO personaDTO = null;
            if (filas.Read())
            {
                personaDTO = new PersonaDTO
                {
                    Idusuario = filas.GetInt32(0),
                    Idestadocivil = filas.GetInt32(1),
                    Nombre = filas.GetString(2),
                    Apellido = filas.GetString(3),
                    Fecha_nacimiento = filas.GetDateTime(4),
                };
            }
            filas.Close();
            conexion.Close();
            return personaDTO;
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