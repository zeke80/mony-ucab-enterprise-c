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
        UsuarioDTO buscar(int idUsuario);
        UsuarioDTO buscarPersona(string user, string contra);
        UsuarioDTO buscarComercio(string user, string contra);
        void crear();
        void actualizar();
        void eliminar();
    }
}
