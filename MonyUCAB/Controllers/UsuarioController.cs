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

namespace MonyUCAB.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> login(Usuario usuario)
        {
            IUsuarioDAO usuarioDAO = new UsuarioDAOPsql();
            return usuarioDAO.buscar(usuario.user, usuario.contra)[0];
        }

        /*        [HttpPost]
        public async Task<ActionResult<UsuarioDTO>> registro(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return BadRequest();
        }*/
    }
}
