using Core.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using WebAPI.DTOS;

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

        [HttpPost("Sencillo")]
        public async Task<ActionResult<Vehiculo>> CrearVehiculoDesdeDto([FromBody] InvitadosDTO dto)
        {
            var invitado = new Invitado
            {
                Nombre = dto.nombre,
                Apellidos = dto.apellidos,
                TipoInvitacion = dto.tipoInvitacion.Equals("Permanente") ? TipoInvitacion.Recurrente : TipoInvitacion.PorFecha,
                FechaInicioValidez = dto.fechaInicio.Equals("") ? null : DateTime.Parse(dto.fechaInicio),
                FechaFinValidez = dto.fechaFin.Equals("") ? null : DateTime.Parse(dto.fechaFin),
                CodigoQR = GenerarCodigoQR(),
                ResidenteId = int.Parse(dto.residenteId)
            };

            _context.Invitados.Add(invitado);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInvitado), new { id = invitado.Id }, invitado);
        }



        private string GenerarCodigoQR()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string codigo;

            using (var context = new ControlDbContext())
            {
                do
                {
                    // Genera una cadena aleatoria de 16 caracteres
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 16; i++)
                    {
                        sb.Append(caracteres[random.Next(caracteres.Length)]);
                    }
                    codigo = sb.ToString();

                    // Verifica que no exista
                } while (context.Residentes.Any(r => r.CodigoQR == codigo) ||
                         context.Invitados.Any(i => i.CodigoQR == codigo));
            }

            return codigo;
        }
    }


}
