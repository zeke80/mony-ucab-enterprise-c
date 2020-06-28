using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface ITarjetaDAO
    {
        TarjetaDTO buscarTarjeta(int idTarjeta);
        List<TarjetaDTO> buscarTarjetas(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
        void AgregarTarjeta(int idusuario, int idtipotarjeta, int idbanco,int numero,
         string fecha_vencimiento, int cvc );
        
    
    }
}
