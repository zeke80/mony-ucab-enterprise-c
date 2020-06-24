using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonyUCAB.Models;
using MonyUCAB.DAO;
using MonyUCAB.DAO.Psql;
using MonyUCAB.DTO;
using MailKit.Net.Smtp;
using MimeKit;

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
            try
            {
                IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
                UsuarioDTO usuarioDTO = usuarioDAO.buscarPersona(infoLogin.user, infoLogin.contra);

                if (usuarioDTO == null)
                    return NotFound();

                return usuarioDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> loginComercio(InfoLogin infoLogin)
        {
            try { 
                IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
                UsuarioDTO usuarioDTO = usuarioDAO.buscarComercio(infoLogin.user, infoLogin.contra);

                if (usuarioDTO == null)
                    return NotFound();

            return usuarioDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> infoUsuario(Id idUsuario)
        {
            try
            {
                IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
                UsuarioDTO usuarioDTO = usuarioDAO.buscar(idUsuario.id);

                if (usuarioDTO == null)
                    return NotFound();

                return usuarioDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<PersonaDTO>> infoPersona(Id idUsuario)
        {
            try
            {
                IPersonaDAO personaDAO = new PersonaDAOPsql();
                PersonaDTO personaDTO = personaDAO.buscar(idUsuario.id);

                if (personaDTO == null)
                    return NotFound();

                return personaDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ComercioDTO>> infoComercio(Id idUsuario)
        {
            try
            {
                IComercioDAO comercioDAO = new ComercioDAOPsql();
                ComercioDTO comercioDTO = comercioDAO.buscar(idUsuario.id);

                if (comercioDTO == null)
                    return NotFound();

                return comercioDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<CuentaDTO>> infoCuenta(Id idCuenta)
        {
            try
            {
                ICuentaDAO cuentaDAO = new CuentaDAOPsql();
                CuentaDTO cuentaDTO = cuentaDAO.buscarCuenta(idCuenta.id);

                if (cuentaDTO == null)
                    return NotFound();

                return cuentaDTO;
}
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<CuentaDTO>>> infoCuentas(Id idUsuario)
        {
            try
            {
                ICuentaDAO cuentaDAO = new CuentaDAOPsql();
                List<CuentaDTO> cuentaDTOs = cuentaDAO.buscarCuentas(idUsuario.id);

                return cuentaDTOs;
}
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<TarjetaDTO>> infoTarjeta(Id idTarjeta)
        {
            try
            {
                ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
                TarjetaDTO tarjetaDTO = tarjetaDAO.buscarTarjeta(idTarjeta.id);

                if (tarjetaDTO == null)
                    return NotFound();

                return tarjetaDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<TarjetaDTO>>> infoTarjetas(Id idUsuario)
        {
            try
            {
                ITarjetaDAO tarjetaDAO = new TarjetaDAOPsql();
                List<TarjetaDTO> tarjetaDTOs = tarjetaDAO.buscarTarjetas(idUsuario.id);

                return tarjetaDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionCuentaDTO>> operacionCuenta(Id idOperacionCuenta)
        {
            try
            {
                IOperacionCuentaDAO OperacionCuentaDAO = new OperacionCuentaDAOPsql();
                OperacionCuentaDTO operacionCuentaDTO = OperacionCuentaDAO.buscarOperacionCuenta(idOperacionCuenta.id);

                if (operacionCuentaDTO == null)
                    return NotFound();

                return operacionCuentaDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionCuentaDTO>>> operacionesCuentas(Id idUsuario)
        {
            try
            {
                IOperacionCuentaDAO OperacionCuentaDAO = new OperacionCuentaDAOPsql();
                List<OperacionCuentaDTO> operacionCuentaDTOs = OperacionCuentaDAO.buscarOperacionesCuentas(idUsuario.id);

                return operacionCuentaDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionTarjetaDTO>> operacionTarjeta(Id idOperacionTarjeta)
        {
            try
            {
                IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
                OperacionTarjetaDTO operacionTarjetaDTO = operacionTarjetaDAO.buscarOperacionTarjeta(idOperacionTarjeta.id);

                if (operacionTarjetaDTO == null)
                    return NotFound();

                return operacionTarjetaDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionTarjetaDTO>>> operacionesTarjetas(Id idUsuario)
        {
            try
            {
                IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
                List<OperacionTarjetaDTO> operacionTarjetaDTOs = operacionTarjetaDAO.buscarOperacionesTarjetas(idUsuario.id);

                return operacionTarjetaDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<OperacionesMonederoDTO>> operacionMonedero(Id idOperacionMonedero)
        {
            try
            {
                IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
                OperacionesMonederoDTO operacionesMonederoDTO = operacionesMonederoDAO.buscarOperacionMonedero(idOperacionMonedero.id);

                if (operacionesMonederoDTO == null)
                    return NotFound();

                return operacionesMonederoDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<OperacionesMonederoDTO>>> operacionesMonedero(Id idUsuario)
        {
            try
            {
                IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
                List<OperacionesMonederoDTO> operacionesMonederoDTOs = operacionesMonederoDAO.buscarOperacionesMonedero(idUsuario.id);

                return operacionesMonederoDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<ReintegroDTO>> infoReintegro(Id idReintegro)
        {
            try
            {
                IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
                ReintegroDTO reintegroDTO = reintegroDAO.buscarReintegro(idReintegro.id);

                if (reintegroDTO == null)
                    return NotFound();

                return reintegroDTO;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<ReintegroDTO>>> infoReintegros(Id idUsuario)
        {
            try
            {
                IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
                List<ReintegroDTO> reintegroDTOs = reintegroDAO.buscarReintegros(idUsuario.id);

                return reintegroDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> solicitarReintegro(Referencia referencia)
        {
            try
            {
                IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
                reintegroDAO.solicitar(referencia.referencia);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> aceptarReintegro(Id idReintegro)
        {
            try
            {
                IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
                reintegroDAO.aceptar(idReintegro.id);

                IPagoDAO pagoDAO = new PagoDAOPsql();
                pagoDAO.actualizarPagoReintegrado(idReintegro.id);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> rechazarReintegro(Id idReintegro)
        {
            try
            {
                IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
                reintegroDAO.rechazar(idReintegro.id);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<int>> solicitarPago(InfoPago infoPago)
        {
            try
            {
                IPagoDAO pagoDAO = new PagoDAOPsql();
                int idPago = pagoDAO.solicitar(infoPago.idUsuarioSolicitante, infoPago.userReceptor, infoPago.monto);

                return idPago;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<PagoDTO>>> pagosSolicitadosSolicitante(Id idUsuarioSolicitante)
        {
            try
            {
                IPagoDAO pagoDAO = new PagoDAOPsql();
                List<PagoDTO> pagoDTOs = pagoDAO.pagosSolicitadosSolicitante(idUsuarioSolicitante.id);

                return pagoDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<PagoDTO>>> pagosSolicitadosReceptor(Id idUsuarioReceptor)
        {
            try
            {
                IPagoDAO pagoDAO = new PagoDAOPsql();
                List<PagoDTO> pagoDTOs = pagoDAO.pagosSolicitadosReceptor(idUsuarioReceptor.id);

                return pagoDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoCuenta(InfoOperacion infoOperacion)
        {
            try
            {
                IOperacionCuentaDAO operacionCuentaDAO = new OperacionCuentaDAOPsql();
                operacionCuentaDAO.realizar(infoOperacion.idOrigen, infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

                IPagoDAO pagoDAO = new PagoDAOPsql();
                pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

                IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
                operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoTarjeta(InfoOperacion infoOperacion)
        {
            try
            {
                IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
                operacionTarjetaDAO.realizar(infoOperacion.idOrigen, infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

                IPagoDAO pagoDAO = new PagoDAOPsql();
                pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

                IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
                operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoMonedero(InfoOperacion infoOperacion)
        {
            try
            {
                IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
                operacionesMonederoDAO.registrarOperacionMonederoRemitente(infoOperacion.idOrigen, infoOperacion.monto, infoOperacion.referencia);
                operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

                IPagoDAO pagoDAO = new PagoDAOPsql();
                pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarUsuario(InfoUsuario infoUsuario)
        {
            try
            {
                IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
                usuarioDAO.ajustar(infoUsuario.idUsuario, infoUsuario.user, infoUsuario.di, infoUsuario.email, infoUsuario.telf, infoUsuario.dir);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarComercio(InfoComercio infoComercio)
        {
            try
            {
                IComercioDAO comercioDAO = new ComercioDAOPsql();
                comercioDAO.ajustar(infoComercio.idUsuario, infoComercio.razonSocial, infoComercio.nombre, infoComercio.apellido);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarPersona(InfoPersona infoPersona)
        {
            try
            {
                IPersonaDAO personaDAO = new PersonaDAOPsql();
                personaDAO.ajustar(infoPersona.idUsuario, infoPersona.nombre, infoPersona.apellido);

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<decimal>> saldo(Id idUsuario)
        {
            try
            {
                IPagoDAO pagoDAO = new PagoDAOPsql();
                decimal saldo = pagoDAO.saldo(idUsuario.id);

                return saldo;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<PagoDTO>>> cierre(Id idUsuario)
        {
            try
            {
                IPagoDAO pagoDAO = new PagoDAOPsql();
                List<PagoDTO> pagoDTOs = pagoDAO.cierre(idUsuario.id);

                return pagoDTOs;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> enviarEmail(InfoRecuperarPass infoRecuperarPass)
        {
            try
            {
                IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
                UsuarioDTO usuarioDTO = usuarioDAO.buscarUserAndPass(infoRecuperarPass.email);

                if (usuarioDTO != null)
                {
                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("MonyUCAB", "monyucabempresac@gmail.com"));
                    message.To.Add(new MailboxAddress(infoRecuperarPass.email));
                    message.Subject = "MonyUCAB - Recuperacion de usuario y contraseña";
                    message.Body = new TextPart("plain")
                    {
                        Text = String.Format(@"Hola {0}!,

                        Este es un correo de recuperacion de usuario y contraseña
                          
                        Usuario   : {0}
                        Contraseña: {1}"
                        , usuarioDTO.Usuario, usuarioDTO.Contrasena)
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("monyucabempresac@gmail.com", "monyucab123");
                        client.Send(message);
                        client.Disconnect(true);
                        client.Dispose();
                    }

                }

                return true;
            }
            catch (Exception e)
            {
                return Conflict();
            }
        }
    }
}
