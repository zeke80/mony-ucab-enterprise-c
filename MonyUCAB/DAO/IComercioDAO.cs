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
        ComercioDTO buscar(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
        void ajustar(int idUsuario, string razonSocial, string nombre, string apellido);

        void registrarComercio(int idusuario,string razon_social, string nombre_representante, string apellido_representante);
    }
}
