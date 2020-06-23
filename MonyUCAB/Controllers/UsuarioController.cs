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
using System.Net;
using System.Net.Mail;

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

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> solicitarReintegro(InfoReintegro infoReintegro)
        {
            IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
            reintegroDAO.solicitar(infoReintegro.idUsuarioSolicitante, infoReintegro.idUsuarioReceptor, infoReintegro.referencia);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> aceptarReintegro(Id idReintegro)
        {
            IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
            reintegroDAO.aceptar(idReintegro.id);

            IPagoDAO pagoDAO = new PagoDAOPsql();
            pagoDAO.actualizarPagoReintegrado(idReintegro.id);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> rechazarReintegro(Id idReintegro)
        {
            IReintegroDAO reintegroDAO = new ReintegroDAOPsql();
            reintegroDAO.rechazar(idReintegro.id);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<int>> solicitarPago(InfoPago infoPago)
        {
            IPagoDAO pagoDAO = new PagoDAOPsql();
            int idPago = pagoDAO.solicitar(infoPago.idUsuarioSolicitante, infoPago.userReceptor, infoPago.monto);

            return idPago;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<PagoDTO>>> pagosSolicitadosSolicitante(Id idUsuarioSolicitante)
        {
            IPagoDAO pagoDAO = new PagoDAOPsql();
            List<PagoDTO> pagoDTOs = pagoDAO.pagosSolicitadosSolicitante(idUsuarioSolicitante.id);

            return pagoDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<List<PagoDTO>>> pagosSolicitadosReceptor(Id idUsuarioReceptor)
        {
            IPagoDAO pagoDAO = new PagoDAOPsql();
            List<PagoDTO> pagoDTOs = pagoDAO.pagosSolicitadosReceptor(idUsuarioReceptor.id);

            return pagoDTOs;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoCuenta(InfoOperacion infoOperacion)
        {
            IOperacionCuentaDAO operacionCuentaDAO = new OperacionCuentaDAOPsql();
            operacionCuentaDAO.realizar(infoOperacion.idOrigen, infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

            IPagoDAO pagoDAO = new PagoDAOPsql();
            pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

            IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
            operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoTarjeta(InfoOperacion infoOperacion)
        {
            IOperacionTarjetaDAO operacionTarjetaDAO = new OperacionTarjetaDAOPsql();
            operacionTarjetaDAO.realizar(infoOperacion.idOrigen, infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

            IPagoDAO pagoDAO = new PagoDAOPsql();
            pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

            IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
            operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> realizarPagoMonedero(InfoOperacion infoOperacion)
        {
            IOperacionesMonederoDAO operacionesMonederoDAO = new OperacionesMonederoDAOPsql();
            operacionesMonederoDAO.registrarOperacionMonederoRemitente(infoOperacion.idOrigen, infoOperacion.monto, infoOperacion.referencia);
            operacionesMonederoDAO.registrarOperacionMonederoDestinatario(infoOperacion.usuarioReceptor, infoOperacion.monto, infoOperacion.referencia);

            IPagoDAO pagoDAO = new PagoDAOPsql();
            pagoDAO.actualizarSolicitudPagada(infoOperacion.referencia);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarUsuario(InfoUsuario infoUsuario)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            usuarioDAO.ajustar(infoUsuario.idUsuario, infoUsuario.user, infoUsuario.di, infoUsuario.email, infoUsuario.telf, infoUsuario.dir);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarComercio(InfoComercio infoComercio)
        {
            IComercioDAO comercioDAO = new ComercioDAOPsql();
            comercioDAO.ajustar(infoComercio.idUsuario, infoComercio.razonSocial, infoComercio.nombre, infoComercio.apellido);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<bool>> ajustarPersona(InfoPersona infoPersona)
        {
            IPersonaDAO personaDAO = new PersonaDAOPsql();
            personaDAO.ajustar(infoPersona.idUsuario, infoPersona.nombre, infoPersona.apellido);

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<decimal>> saldo(Id idUsuario)
        {
            IPagoDAO pagoDAO = new PagoDAOPsql();
            decimal saldo = pagoDAO.saldo(idUsuario.id);

            return saldo;
        }
        public async Task<ActionResult<string>> enviarEmail(InfoRecuperarPass infoRecuperarPass)
        {
            string respuesta = "Correo enviado";
            //verificas que el usuario sea valido
           IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            UsuarioDTO usuarioDTO = usuarioDAO.buscarPersonabyEmail(infoRecuperarPass.email);
            if (usuarioDTO == null)
                return NotFound();

            IUsuarioDAO usuarioDAO1 = new UsuarioDAOPsql();
            UsuarioDTO usuarioDTO1 = usuarioDAO1.buscarUserAndPass(infoRecuperarPass.email);

            string emailOrigen = "carlosjpa1305@gmail.com";
            string contrasena = "26473558";
            

            MailMessage mailRecuperacion = new MailMessage
            (emailOrigen,
            infoRecuperarPass.email,
            "Recuperacion de contraseña",
            "Esperamos tenga un buen dia, ha solicitado recuperar su contraseña :" + usuarioDTO1.Usuario);

            mailRecuperacion.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient ("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port= 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(emailOrigen, contrasena);;

            smtpClient.Send(mailRecuperacion);
            smtpClient.Dispose();
            //puse return solo para devolver algo
            return respuesta;
        }
    }
}
