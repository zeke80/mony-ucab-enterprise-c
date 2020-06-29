using MonyUCAB.DTO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class PersonaDAOPsql : DAOPsql, IPersonaDAO
    {
        public void ajustar(int idUsuario, string nombre, string apellido)
        {
            try
            {
                comando.CommandText = string.Format("SELECT PersonaDAOPsqlajustar( {2}, '{0}', '{1}')", nombre, apellido, idUsuario);
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

        public PersonaDTO buscar(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT * FROM PersonaDAOPsqlbuscar({0})", idUsuario);
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
                return personaDTO;
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

        public void registraPersona(int idUsuario, int idestadocivil, string nombre, string apellido, string fecha_nacimiento)
        {
            try
            {
                comando.CommandText = string.Format(
                    "INSERT INTO persona(" +
                        "idusuario, " +
                        "idestadocivil, " +
                        "nombre, " +
                        "apellido, " +
                        "fecha_nacimiento " +
                    ") " +
                    "values" +
                    "({0}, {1}, '{2}', '{3}', to_date('{4}','yyyy-MM-dd'))",
                    idUsuario, idestadocivil, nombre, apellido, fecha_nacimiento);
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
    }
}