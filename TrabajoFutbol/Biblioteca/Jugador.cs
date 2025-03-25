namespace Biblioteca;

public class Jugador
{
    internal double VisionDelJuego;
    internal double Potencia;
    internal double VisionDeLosCompanieros;
    public double HabilidadEnLosPases { get; set; }

    public ITipoJugador TipoJugador;

    public Jugador(ITipoJugador tipoJugador, double visionDelJuego, double potencia, double habilidadEnLosPases, double visionDeLosCompanieros)
    {
        TipoJugador = tipoJugador;
        VisionDelJuego = visionDelJuego;
        VisionDeLosCompanieros = visionDeLosCompanieros;
        Potencia = potencia;
        HabilidadEnLosPases = habilidadEnLosPases;
    }
    public double GetPrecision()
    {
        double resultado = TipoJugador.GetPrecision(this);
        return resultado;
    }

    public double GetVisionGeneral()
    {
        double resultado = TipoJugador.GetVisionGeneral(this);
        return resultado;
    }

    public void AplicarEntrenamientoFisico()
    {
        TipoJugador.AplicarEntrenamientoFisico(this);
    }

    public void AplicarEntrenamientoLirico()
    {
        TipoJugador.AplicarEntrenamientoLirico(this);
    }
    public void AplicarEntrenamientoTactico()
    {
        TipoJugador.AplicarEntrenamientoTactico(this);
    }

}