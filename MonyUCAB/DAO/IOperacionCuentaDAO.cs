using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IOperacionCuentaDAO
    {
        OperacionCuentaDTO buscarOperacionCuenta(int idOperacionCuenta);
        List<OperacionCuentaDTO> buscarOperacionesCuentas(int idUsuario);
        void crear();
        void actualizar();
        void eliminar();
        void realizar(int idCuenta, string usuarioReceptor, float monto, int referencia);

        List<OperacionCuentaDTO> FiltrarByFechas(int idusuario,string fechainicio, string fechafinal);
    }
}
