using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IOperacionTarjetaDAO
    {
        OperacionTarjetaDTO buscarOperacionTarjeta(int idOperacionTarjeta);
        List<OperacionTarjetaDTO> buscarOperacionesTarjetas(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
        void realizar(int idTarjeta, string usuarioReceptor, float monto, int referencia);
        List<OperacionTarjetaDTO> FiltrarByFechas(int idusuario,string fechainicio, string fechafinal);
    }
}
