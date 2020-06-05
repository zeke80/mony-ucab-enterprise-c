using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IUsuarioDAO
    {
        List<UsuarioDTO> buscar(string user, string contra);
        void crear();
        void actualizar();
        void eliminar();
    }
}
