namespace Biblioteca;

public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public List<Ticket> Tickets { get; private set; }
    public Cliente(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        Tickets = new List<Ticket>();
    }
}