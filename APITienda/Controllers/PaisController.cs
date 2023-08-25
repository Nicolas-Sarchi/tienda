using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APITienda.Controllers;

public class PaisController : BaseApiController
{
    private readonly TiendaContext _context;

    public PaisController(TiendaContext context)
    {
        _context = context;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var varName = await _context.Paises.ToListAsync();
        return Ok(varName);
    }

}
