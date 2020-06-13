using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface ICuentaDAO
    {
        CuentaDTO buscarCuenta(int idCuenta);
        List<CuentaDTO> buscarCuentas(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
    }
}
