﻿using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonyUCAB.DAO.Psql
{
    public class TarjetaDAOPsql : DAOPsql, ITarjetaDAO
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public TarjetaDTO buscarTarjeta(int idTarjeta)
        {
            comando.CommandText = string.Format("SELECT " +
                "idtarjeta," +
                "idusuario," +
                "idtipotarjeta," +
                "idbanco," +
                "numero," +
                "fecha_vencimiento," +
                "cvc," +
                "estatus " +
                "FROM tarjeta " +
                "WHERE idtarjeta = {0}", idTarjeta);
            conexion.Open();
            filas = comando.ExecuteReader();
            TarjetaDTO tarjetaDTO = null;
            if (filas.Read())
            {
                tarjetaDTO = new TarjetaDTO
                {
                    Idtarjeta = filas.GetInt32(0),
                    Idusuario = filas.GetInt32(1),
                    Idtipotarjeta = filas.GetInt32(2),
                    Idbanco = filas.GetInt32(3),
                    Numero = filas.GetInt32(4),
                    Fecha_vencimiento = filas.GetDateTime(5),
                    Cvc = filas.GetInt32(6),
                    Estatus = filas.GetInt32(7),
                };
            }
            filas.Close();
            conexion.Close();
            return tarjetaDTO;
        }

        public List<TarjetaDTO> buscarTarjetas(int idUsuario)
        {
            comando.CommandText = string.Format("SELECT " +
                "idtarjeta," +
                "idusuario," +
                "idtipotarjeta," +
                "idbanco," +
                "numero," +
                "fecha_vencimiento," +
                "cvc," +
                "estatus " +
                "FROM tarjeta " +
                "WHERE idusuario = {0}", idUsuario);
            conexion.Open();
            filas = comando.ExecuteReader();
            List<TarjetaDTO> tarjetaDTOs = new List<TarjetaDTO>();
            while (filas.Read())
            {
                tarjetaDTOs.Add(new TarjetaDTO
                {
                    Idtarjeta = filas.GetInt32(0),
                    Idusuario = filas.GetInt32(1),
                    Idtipotarjeta = filas.GetInt32(2),
                    Idbanco = filas.GetInt32(3),
                    Numero = filas.GetInt32(4),
                    Fecha_vencimiento = filas.GetDateTime(5),
                    Cvc = filas.GetInt32(6),
                    Estatus = filas.GetInt32(7),
                });
            }
            filas.Close();
            conexion.Close();
            return tarjetaDTOs;
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