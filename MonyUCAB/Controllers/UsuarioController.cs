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
        public async Task<ActionResult<UsuarioDTO>> infoUsuario(Id idUsuario)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            UsuarioDTO usuarioDTO = usuarioDAO.buscar(idUsuario.id);

            if (usuarioDTO == null)
                return NotFound();

            return usuarioDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<PersonaDTO>> infoPersona(Id idUsuario)
        {
            IPersonaDAO personaDAO = new PersonaDAOPsql();
            PersonaDTO personaDTO = personaDAO.buscar(idUsuario.id);

            if (personaDTO == null)
                return NotFound();

            return personaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ComercioDTO>> infoComercio(Id idUsuario)
        {
            IComercioDAO comercioDAO = new ComercioDAOPsql();
            ComercioDTO comercioDTO = comercioDAO.buscar(idUsuario.id);

            if (comercioDTO == null)
                return NotFound();

            return comercioDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<CuentaDTO>> infoCuenta(Id idCuenta)
        {
            ICuentaDAO cuentaDAO = new CuentaDAOPsql();
            CuentaDTO cuentaDTO = cuentaDAO.buscarCuenta(idCuenta.id);

            if (cuentaDTO == null)
                return NotFound();

            return cuentaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<CuentaDTO>>> infoCuentas(Id idUsuario)
        {
            ICuentaDAO cuentaDAO = new CuentaDAOPsql();
            List<CuentaDTO> cuentaDTOs = cuentaDAO.buscarCuentas(idUsuario.id);

            return cuentaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<TarjetaDTO>> infoTarjeta(Id idTarjeta)
        {
            ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
            TarjetaDTO tarjetaDTO = tarjetaDAO.buscarTarjeta(idTarjeta.id);

            if (tarjetaDTO == null)
                return NotFound();

            return tarjetaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<TarjetaDTO>>> infoTarjetas(Id idUsuario)
        {
            ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
            List<TarjetaDTO> tarjetaDTOs = tarjetaDAO.buscarTarjetas(idUsuario.id);

            return tarjetaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionCuentaDTO>> operacionCuenta(Id idOperacionCuenta)
        {
            IOperacionCuentaDAO OperacionCuentaDAO = new OperacionCuentaDAOPsql();
            OperacionCuentaDTO operacionCuentaDTO = OperacionCuentaDAO.buscarOperacionCuenta(idOperacionCuenta.id);

            if (operacionCuentaDTO == null)
                return NotFound();

            return operacionCuentaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionCuentaDTO>>> operacionesCuentas(Id idUsuario)
        {
            IOperacionCuentaDAO OperacionCuentaDAO = new OperacionCuentaDAOPsql();
            List<OperacionCuentaDTO> operacionCuentaDTOs = OperacionCuentaDAO.buscarOperacionesCuentas(idUsuario.id);

            return operacionCuentaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionTarjetaDTO>> operacionTarjeta(Id idOperacionTarjeta)
        {
            IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
            OperacionTarjetaDTO operacionTarjetaDTO = operacionTarjetaDAO.buscarOperacionTarjeta(idOperacionTarjeta.id);

            if (operacionTarjetaDTO == null)
                return NotFound();

            return operacionTarjetaDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionTarjetaDTO>>> operacionesTarjetas(Id idUsuario)
        {
            IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
            List<OperacionTarjetaDTO> operacionTarjetaDTOs = operacionTarjetaDAO.buscarOperacionesTarjetas(idUsuario.id);

            return operacionTarjetaDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionesMonederoDTO>> operacionMonedero(Id idOperacionMonedero)
        {
            IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
            OperacionesMonederoDTO operacionesMonederoDTO = operacionesMonederoDAO.buscarOperacionMonedero(idOperacionMonedero.id);

            if (operacionesMonederoDTO == null)
                return NotFound();

            return operacionesMonederoDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionesMonederoDTO>>> operacionesMonedero(Id idUsuario)
        {
            IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
            List<OperacionesMonederoDTO> operacionesMonederoDTOs = operacionesMonederoDAO.buscarOperacionesMonedero(idUsuario.id);

            return operacionesMonederoDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ReintegroDTO>> infoReintegro(Id idReintegro)
        {
            IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
            ReintegroDTO reintegroDTO = reintegroDAO.buscarReintegro(idReintegro.id);

            if (reintegroDTO == null)
                return NotFound();

            return reintegroDTO;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<ReintegroDTO>>> infoReintegros(Id idUsuario)
        {
            IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
            List<ReintegroDTO> reintegroDTOs = reintegroDAO.buscarReintegros(idUsuario.id);

            return reintegroDTOs;
        }
    }
}
