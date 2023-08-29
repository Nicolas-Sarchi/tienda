using APITienda.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APITienda.Controllers;

public class EstadoController
{
    private IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public EstadoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitofwork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<EstadoDto>>> Get()
    {
        var estados = await unitofwork.Estados.GetAllAsync();
        return mapper.Map<List<EstadoDto>>(estados);
    }


}
