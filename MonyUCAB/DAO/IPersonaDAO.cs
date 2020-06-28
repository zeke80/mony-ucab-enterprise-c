using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonyUCAB.DAO
{
    interface IPersonaDAO
    {
        PersonaDTO buscar(int idUsuario);
        void ajustar(int idUsuario, string nombre, string apellido);
        void registraPersona(int idUsuario, int idestadocivil, string nombre, string apellido, string fecha_nacimiento);
    }
}
