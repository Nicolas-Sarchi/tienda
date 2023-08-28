using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace APITienda.Controllers;

public class PaisController : BaseApiController
{
    private IUnitOfWork unitofwork;

    public PaisController(IUnitOfWork unitOfWork)
    {
        this.unitofwork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var paises = await unitofwork.Paises.GetAllAsync();
        return Ok(paises);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pais>> Get(int id)
    {
        var pais = await unitofwork.Paises.GetByIdAsync(id);
        return Ok(pais);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pais>> Post(Pais pais)
    {
        unitofwork.Paises.Add(pais);
        await unitofwork.SaveAsync();
        if (pais == null){
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new { id = pais.Id }, pais);
    }

}
