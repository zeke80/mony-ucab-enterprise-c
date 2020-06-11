using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonyUCAB.Models;
using MonyUCAB.DAO;
using MonyUCAB.DAO.Psql;
using MonyUCAB.DTO;
using Microsoft.AspNetCore.Cors;

namespace MonyUCAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> loginPersona(InfoLogin infoLogin)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            UsuarioDTO usuarioDTO = usuarioDAO.buscarPersona(infoLogin.user, infoLogin.contra);

            if (usuarioDTO == null)
                return NotFound();

            return usuarioDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> loginComercio(InfoLogin infoLogin)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            UsuarioDTO usuarioDTO = usuarioDAO.buscarComercio(infoLogin.user, infoLogin.contra);

            if (usuarioDTO == null)
                return NotFound();

            return usuarioDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<PersonaDTO>> infoPersona(IdUsuario idUsuario)
        {
            IPersonaDAO personaDAO = new PersonaDAOPsql();
            PersonaDTO personaDTO = personaDAO.buscar(idUsuario.id);

            if (personaDTO == null)
                return NotFound();

            return personaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ComercioDTO>> infoComercio(IdUsuario idUsuario)
        {
            IComercioDAO comercioDAO = new ComercioDAOPsql();
            ComercioDTO comercioDTO = comercioDAO.buscar(idUsuario.id);

            if (comercioDTO == null)
                return NotFound();

            return comercioDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<CuentaDTO>>> infoCuentas(IdUsuario idUsuario)
        {
            ICuentaDAO cuentaDAO = new CuentaDAOPsql();
            List<CuentaDTO> cuentaDTOs = cuentaDAO.buscar(idUsuario.id);

            return cuentaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<TarjetaDTO>>> infoTarjetas(IdUsuario idUsuario)
        {
            ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
            List<TarjetaDTO> tarjetaDTOs = tarjetaDAO.buscar(idUsuario.id);

            return tarjetaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionCuentaDTO>>> operacionesCuenta(IdUsuario idUsuario)
        {
            IOperacionCuentaDAO OperacionCuentaDAO = new OperacionCuentaDAOPsql();
            List<OperacionCuentaDTO> operacionCuentaDTOs = OperacionCuentaDAO.buscar(idUsuario.id);

            return operacionCuentaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionTarjetaDTO>>> operacionesTarjeta(IdUsuario idUsuario)
        {
            IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
            List<OperacionTarjetaDTO> operacionTarjetaDTOs = operacionTarjetaDAO.buscar(idUsuario.id);

            return operacionTarjetaDTOs;
        }
    }
}
