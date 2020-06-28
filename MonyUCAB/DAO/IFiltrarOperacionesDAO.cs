using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IFiltrarOperacionesDAO
    {
        List<FiltrarOperacionesDTO> FiltrarByFechas(int idusuario,string fechainicio, string fechafin);
        void crear();
        void actualizar();
        void eliminar();
        
    }
}
