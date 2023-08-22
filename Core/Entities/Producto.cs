namespace Core.Entities;

public class Producto
{
    public int Id { get; set;}
    public string ? CodInterno { get; set; }
    public string? Nombre { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public double ValorVta { get; set; }
}
