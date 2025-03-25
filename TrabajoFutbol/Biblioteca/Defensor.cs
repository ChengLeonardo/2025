namespace Biblioteca;

public class Defensor : ITipoJugador
{
    public double Quite;
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
        return Quite;
    }

    public double GetVisionGeneral(Jugador jugador)
    {
        throw new NotImplementedException();
    }
}