﻿using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface ITarjetaDAO
    {
        TarjetaDTO buscarTarjeta(int idTarjeta);
        List<TarjetaDTO> buscarTarjetas(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
    }
}