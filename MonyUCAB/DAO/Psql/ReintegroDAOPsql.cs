using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MonyUCAB.DTO;


namespace MonyUCAB.DAO
{
    public class ReintegroDAOPsql : DAOPsql, IReintegroDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public ReintegroDTO buscarReintegro(int idReintegro)
        {
            comando.CommandText = string.Format(
                "SELECT " +
                    "rei.idreintegro," +
                    "rei.idusuario_solicitante," +
                    "rei.idusuario_receptor," +
                    "rei.fecha_solicitud," +
                    "rei.referencia," +
                    "rei.estatus " +
                "FROM reintegro rei " +
                "WHERE rei.idreintegro = {0}", idReintegro);
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
                    Fecha_solicitud = filas.GetString(3),
                    Referencia = filas.GetString(4),
                    Estatus = filas.GetString(5),
                };
            }
            filas.Close();
            conexion.Close();
            return reintegroDTO;
        }

        public List<ReintegroDTO> buscarReintegros(int idUsuario)
        {
            comando.CommandText = string.Format(
                "SELECT " +
                    "rei.idreintegro," +
                    "rei.idusuario_solicitante," +
                    "rei.idusuario_receptor," +
                    "rei.fecha_solicitud," +
                    "rei.referencia," +
                    "rei.estatus " +
                "FROM reintegro rei " +
                "WHERE rei.idusuario_solicitante = {0} " +
                "OR rei.idusuario_receptor = {0}", idUsuario);
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
                    Fecha_solicitud = filas.GetString(3),
                    Referencia = filas.GetString(4),
                    Estatus = filas.GetString(5),
                });
            }
            filas.Close();
            conexion.Close();
            return reintegroDTOs;
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