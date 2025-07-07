using Core.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosAccesoController : ControllerBase
    {
        private readonly ControlDbContext _context;

        public RegistrosAccesoController(ControlDbContext context)
        {
            _context = context;
        }

        // GET: api/RegistrosAcceso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroAcceso>>> GetRegistrosAcceso()
        {
            var registros = await _context.RegistrosAcceso
                .Include(r => r.Residente)
                .Include(r => r.Invitado)
                .Include(r => r.Guardia)
                .ToListAsync();

            return Ok(registros);
        }

        // GET: api/RegistrosAcceso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroAcceso>> GetRegistroAcceso(int id)
        {
            var registro = await _context.RegistrosAcceso
                .Include(r => r.Residente)
                .Include(r => r.Invitado)
                .Include(r => r.Guardia)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (registro == null)
                return NotFound();

            return Ok(registro);
        }

        // POST: api/RegistrosAcceso
        [HttpPost]
        public async Task<ActionResult<RegistroAcceso>> CrearRegistroAcceso(RegistroAcceso registro)
        {
            _context.RegistrosAcceso.Add(registro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRegistroAcceso), new { id = registro.Id }, registro);
        }

        // PUT: api/RegistrosAcceso/5
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarRegistroAcceso(int id, RegistroAcceso registro)
        {
            if (id != registro.Id)
                return BadRequest();

            _context.Entry(registro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.RegistrosAcceso.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/RegistrosAcceso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRegistroAcceso(int id)
        {
            var registro = await _context.RegistrosAcceso.FindAsync(id);
            if (registro == null)
                return NotFound();

            _context.RegistrosAcceso.Remove(registro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
