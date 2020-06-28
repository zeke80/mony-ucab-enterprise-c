using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IBancoDAO
    {
        List<BancoDTO> buscar();

        BancoDTO buscarIdbanco(string nombre);
        void registrarBanco(string nombre, int estatus);
        void crear();
        void actualizar();
        void eliminar();
    }
}