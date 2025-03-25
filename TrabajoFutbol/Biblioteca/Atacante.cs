namespace Biblioteca;

public class Atacante : ITipoJugador
{
    public double Anotacion { get; set; }
    public void AplicarEntrenamientoFisico(Jugador jugador)
    {
        throw new NotImplementedException();
    }

    public void AplicarEntrenamientoLirico(Jugador jugador)
    {
        throw new NotImplementedException();
    }

    public void AplicarEntrenamientoTactico(Jugador jugador)
    {
        throw new NotImplementedException();
    }

    public double GetPrecision(Jugador jugador)
    {
        return Anotacion;
    }

    public double GetVisionGeneral(Jugador jugador)
    {
        return jugador.VisionDeLosCompanieros += 
    }
}