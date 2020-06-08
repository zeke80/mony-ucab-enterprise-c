using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IComercioDAO
    {
        List<ComercioDTO> buscar(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
    }
}
