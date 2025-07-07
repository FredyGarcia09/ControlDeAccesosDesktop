using Core.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiasController : ControllerBase
    {
        private readonly ControlDbContext _context;

        public GuardiasController(ControlDbContext context)
        {
            _context = context;
        }

        // GET: api/Guardias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guardia>>> GetGuardias()
        {
            var guardias = await _context.Guardias
                .Include(g => g.RegistrosAcceso)
                .ToListAsync();

            return Ok(guardias);
        }

        // GET: api/Guardias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guardia>> GetGuardia(int id)
        {
            var guardia = await _context.Guardias
                .Include(g => g.RegistrosAcceso)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (guardia == null)
            {
                return NotFound();
            }

            return Ok(guardia);
        }

        // POST: api/Guardias
        [HttpPost]
        public async Task<ActionResult<Guardia>> CrearGuardia(Guardia guardia)
        {
            _context.Guardias.Add(guardia);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGuardia), new { id = guardia.Id }, guardia);
        }

        // PUT: api/Guardias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarGuardia(int id, Guardia guardia)
        {
            if (id != guardia.Id)
                return BadRequest();

            _context.Entry(guardia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Guardias.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Guardias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarGuardia(int id)
        {
            var guardia = await _context.Guardias.FindAsync(id);
            if (guardia == null)
                return NotFound();

            _context.Guardias.Remove(guardia);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
