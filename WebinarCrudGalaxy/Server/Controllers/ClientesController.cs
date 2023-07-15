using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebinarCrudGalaxy.DataAccess;
using WebinarCrudGalaxy.Entities;
using WebinarCrudGalaxy.Shared;

namespace WebinarCrudGalaxy.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly GalaxyDbContext _context;

    public ClientesController(GalaxyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetClientes()
    {
        var data = await _context.Clientes
            .OrderBy(p => p.Nombres)
            .Select(p => new ClienteDtoResponse()
            {
                Id = p.Id,
                Nombres = p.Nombres,
                Apellidos = p.Apellidos,
                Email = p.Email
            })
            .ToListAsync();

        return Ok(data);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente is null)
            return NotFound();

        var response = new ClienteDtoResponse()
        {
            Id = cliente.Id,
            Nombres = cliente.Nombres,
            Apellidos = cliente.Apellidos,
            Email = cliente.Email
        };

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ClienteDtoRequest request)
    {
        var cliente = new Cliente()
        {
            Nombres = request.Nombres,
            Apellidos = request.Apellidos,
            Email = request.Email
        };

        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, ClienteDtoRequest request)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente is null)
            return NotFound();

        cliente.Nombres = request.Nombres;
        cliente.Apellidos = request.Apellidos;
        cliente.Email = request.Email;

        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente is null)
            return NotFound();

        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();

        return Ok();
    }
}