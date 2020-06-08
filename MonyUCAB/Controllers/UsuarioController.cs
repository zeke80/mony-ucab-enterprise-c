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
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> loginPersona(InfoLogin infoLogin)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            return usuarioDAO.buscarPersona(infoLogin.user, infoLogin.contra)[0];
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> loginComercio(InfoLogin infoLogin)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            return usuarioDAO.buscarComercio(infoLogin.user, infoLogin.contra)[0];
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ComercioDTO>> infoComercio(IdUsuario idUsuario)
        {
            IComercioDAO comercioDAO = new ComercioDAOPsql();
            return comercioDAO.buscar(idUsuario.id)[0];
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<CuentaDTO>>> infoCuentas(IdUsuario idUsuario)
        {
            ICuentaDAO cuentaDAO = new CuentaDAOPsql();
            return cuentaDAO.buscar(idUsuario.id);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<TarjetaDTO>>> infoTarjetas(IdUsuario idUsuario)
        {
            ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
            return tarjetaDAO.buscar(idUsuario.id);
        }
    }
}
