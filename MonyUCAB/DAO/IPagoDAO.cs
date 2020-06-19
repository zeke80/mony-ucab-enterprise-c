using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IPagoDAO
    {
        int solicitar(int idUsuarioSolicitante, string userReceptor, float monto);
        List<PagoDTO> buscar();
        void crear();
        void actualizar();
        void eliminar();
        List<PagoDTO> pagosSolicitadosSolicitante(int idUsuarioSolicitante);
        List<PagoDTO> pagosSolicitadosReceptor(int idUsuarioReceptor);
    }
}
