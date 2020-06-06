using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IContrasenaDAO
    {
        List<ContrasenaDTO> buscar();
        void crear();
        void actualizar();
        void eliminar();
    }
}
