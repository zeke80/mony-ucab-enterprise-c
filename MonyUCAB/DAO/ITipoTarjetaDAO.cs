using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface ITipoTarjetaDAO
    {
        List<TipoTarjetaDTO> buscar();
        void crear();
        void actualizar();
        void eliminar();
        TipoTarjetaDTO buscarIdTipotarjeta(string descripcion);
    }
}