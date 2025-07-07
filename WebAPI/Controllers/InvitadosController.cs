using Core.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitadosController : ControllerBase
    {
        private readonly ControlDbContext _context;

        public InvitadosController(ControlDbContext context)
        {
            _context = context;
        }

        // GET: api/Invitados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invitado>>> GetInvitados()
        {
            var invitados = await _context.Invitados
                .Include(i => i.Residente)
                .Include(i => i.RegistrosAcceso)
                .ToListAsync();

            return Ok(invitados);
        }

        // GET: api/Invitados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invitado>> GetInvitado(int id)
        {
            var invitado = await _context.Invitados
                .Include(i => i.Residente)
                .Include(i => i.RegistrosAcceso)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (invitado == null)
            {
                return NotFound();
            }

            return Ok(invitado);
        }

        // POST: api/Invitados
        [HttpPost]
        public async Task<ActionResult<Invitado>> CrearInvitado(Invitado invitado)
        {
            _context.Invitados.Add(invitado);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInvitado), new { id = invitado.Id }, invitado);
        }

        // PUT: api/Invitados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarInvitado(int id, Invitado invitado)
        {
            if (id != invitado.Id)
                return BadRequest();

            _context.Entry(invitado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Invitados.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Invitados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarInvitado(int id)
        {
            var invitado = await _context.Invitados.FindAsync(id);
            if (invitado == null)
                return NotFound();

            _context.Invitados.Remove(invitado);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
