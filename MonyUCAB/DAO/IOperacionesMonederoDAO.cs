using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IOperacionesMonederoDAO
    {
        OperacionesMonederoDTO buscarOperacionMonedero(int idOperacionMonedero);
        List<OperacionesMonederoDTO> buscarOperacionesMonedero(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
    }
}
