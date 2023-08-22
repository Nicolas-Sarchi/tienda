namespace Core.Entities;

public class Persona
{
    public int Id { get; set;}
    public string ?  IdPersona { get; set;}
    public string ? NombrePersona { get; set;}
    public DateOnly FechaNac { get; set;}
    public int IdTipoPer { get; set;}
}
