using Core.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using DataAccess.Data;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResidentesController : ControllerBase
{
    private readonly ControlDbContext _context;

    public ResidentesController(ControlDbContext context)
    {
        _context = context;
    }

    // GET: api/residentes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Residente>>> GetResidentes()
    {
        return await _context.Residentes
            .Include(r => r.Vehiculos) // si quieres traer el vehículo junto
            .ToListAsync();
    }

    // GET: api/residentes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Residente>> GetResidente(int id)
    {
        var residente = await _context.Residentes
            .Include(r => r.Vehiculos)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (residente == null)
            return NotFound();

        return residente;
    }

    // POST: api/residentes
    [HttpPost]
    public async Task<ActionResult<Residente>> PostResidente(Residente residente)
    {
        _context.Residentes.Add(residente);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetResidente), new { id = residente.Id }, residente);
    }

    // PUT: api/residentes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutResidente(int id, Residente residente)
    {
        if (id != residente.Id)
            return BadRequest();

        _context.Entry(residente).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Residentes.Any(r => r.Id == id))
                return NotFound();
            else
                throw;
        }

        return NoContent();
    }

    // DELETE: api/residentes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteResidente(int id)
    {
        var residente = await _context.Residentes.FindAsync(id);
        if (residente == null)
            return NotFound();

        _context.Residentes.Remove(residente);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (!int.TryParse(request.Id, out int idInt))
            return BadRequest("ID inválido");

        var residente = await _context.Residentes.FirstOrDefaultAsync(r => r.Id == idInt);

        if (residente == null)
            return Unauthorized("Residente no encontrado");

        if (residente.ContrasenaHash != request.Password)
            return Unauthorized("Contraseña incorrecta");

        return Ok(new
        {
            id = residente.Id.ToString(),
            nombre = residente.Nombre,
            apellidos = residente.Apellidos,
            domicilio = residente.Domicilio,
            telefono = residente.Telefono,
            codigoQR = residente.CodigoQR
        });
    }


    // GET: api/residentes/5/vehiculos
    [HttpGet("{id}/Vehiculos")]
    public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculosDeResidente(int id)
    {
        var residente = await _context.Residentes
            .Include(r => r.Vehiculos)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (residente == null)
            return NotFound();

        return Ok(residente.Vehiculos);
    }

    // GET: api/residentes/5/invitados
    [HttpGet("{id}/Invitados")]
    public async Task<ActionResult<IEnumerable<Invitado>>> GetInvitadosDeResidente(int id)
    {
        var invitados = await _context.Invitados
            .Where(i => i.ResidenteId == id)
            .ToListAsync();

        return Ok(invitados);
    }


    public class LoginRequest
    {
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
