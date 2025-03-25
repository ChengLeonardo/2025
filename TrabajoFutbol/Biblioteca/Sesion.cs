
namespace Biblioteca;

public abstract class Sesion
{
    public string Nombre { get; set; }

    public abstract void AplicarAl(Jugador jugador);
}