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
    public class ReintegroDAOPsql : DAOPsql, IReintegroDAO
    {
        public ReintegroDTO buscarReintegro(int idReintegro)
        {
            try
            {
                comando.CommandText = string.Format("SELECT buscarReintegro({0})", idReintegro);
                conexion.Open();
                filas = comando.ExecuteReader();
                ReintegroDTO reintegroDTO = null;
                if (filas.Read())
                {
                    reintegroDTO = new ReintegroDTO
                    {
                        Idreintegro = filas.GetInt32(0),
                        Idusuario_solicitante = filas.GetInt32(1),
                        Idusuario_receptor = filas.GetInt32(2),
                        Fecha_solicitud = filas.GetDateTime(3),
                        Referencia = filas.GetInt32(4),
                        Estatus = filas.GetString(5),
                    };
                }
                filas.Close();
                return reintegroDTO;
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

        public List<ReintegroDTO> buscarReintegros(int idUsuario)
        {
            try
            {
                comando.CommandText = string.Format("SELECT buscarReintegros({0})", idUsuario);
                conexion.Open();
                filas = comando.ExecuteReader();
                List<ReintegroDTO> reintegroDTOs = new List<ReintegroDTO>();
                while (filas.Read())
                {
                    reintegroDTOs.Add(new ReintegroDTO
                    {
                        Idreintegro = filas.GetInt32(0),
                        Idusuario_solicitante = filas.GetInt32(1),
                        Idusuario_receptor = filas.GetInt32(2),
                        Fecha_solicitud = filas.GetDateTime(3),
                        Referencia = filas.GetInt32(4),
                        Estatus = filas.GetString(5),
                    });
                }
                filas.Close();
                return reintegroDTOs;
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

        public void solicitar(int referencia)
        {
            try
            {
                comando.CommandText = string.Format("SELECT ReintegroDAOPsqlsolicitar('{0}')",referencia);
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

        public void aceptar(int idReintegro)
        {
            try
            {
                comando.CommandText = string.Format("SELECT ReintegroDAOPsqlaceptar({0})", idReintegro);
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

        public void rechazar(int idReintegro)
        {
            try
            {
                comando.CommandText = string.Format("SELECT ReintegroDAOPsqlrechazar({0})", idReintegro);
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