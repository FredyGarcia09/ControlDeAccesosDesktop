using Core.Models;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using DataAccess.Data;

[ApiController]
[Route("api/[controller]")]
public class ResidentesController : ControllerBase
{
    private readonly ControlDbContext _context;

    public ResidentesController(ControlDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Residente>>> Get()
    {
        return await _context.Residentes.ToListAsync();
    }
}
