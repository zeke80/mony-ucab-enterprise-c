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
        UsuarioDTO buscarPersonabyEmail(string email);
        UsuarioDTO buscarUserAndPass(string email);
        UsuarioDTO buscarComercio(string user, string contra);
        void crear();
        void actualizar();
        void eliminar();
        void ajustar(int idUsuario, string user, int di, string email, string telf, string dir);
        UsuarioDTO buscarIdByUser(string usuario);

        void RegistrarUser(int idtipousuario, int idtipoidentificacion, string usuario, int nro_identificacion,
         string email, string telefono, string direccion, int estatus );
    }
}
