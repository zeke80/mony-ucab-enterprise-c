using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IReintegroDAO
    {
        ReintegroDTO buscarReintegro(int idReintegro);
        List<ReintegroDTO> buscarReintegros(int idUsuario);
        void solicitar(int referencia);
        void aceptar(int idReintegro);
        void rechazar(int idReintegro);
        void actualizar();
        void eliminar();
    }
}
