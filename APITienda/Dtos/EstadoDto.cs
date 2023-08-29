using Core.Entities;

namespace APITienda.Dtos;

    public class EstadoDto
    {
    public string? NombreEstado { get; set; }
    public int IdPaisFk { get; set; }
    public Pais? Pais { get; set; }
    public ICollection<Region>? Regiones { get; set; }

}
