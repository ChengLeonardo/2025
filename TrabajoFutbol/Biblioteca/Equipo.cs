namespace Biblioteca;

public class Equipo
{
    public List<Jugador> Jugadores;
    public List<Sesion> Sesiones;
    public double Potencia { get; set; }
    public double Precision { get; set; }
    public double Vision { get; set; }

    public double GetVision()
    {
        return Jugadores.Sum(jugador => jugador.GetVisionGeneral());
    }

    public double GetPrecision()
    {
        return Jugadores.Sum(jugador => 3 * jugador.HabilidadEnLosPases + jugador.GetPrecision());
    }

    public double GetPotencia()
    {
        //return Jugadores.OrderByDescending(jugador => jugador.Potencia).Select(jugador => jugador.Potencia).Take(2).Sum();
        return Jugadores.Select
            (j=>j.Potencia)
            .OrderDescending()
            .Take(2)
            .Sum();
    }
}