namespace Biblioteca;

public class Jeager : Pelea
{
    public string NombrePiloto;
    public static int TotalJeagersDisponibles;
    public double PoderPelea { get; set; }

    public Jeager(string nombrePiloto, double poderPelea)
    {
        TotalJeagersDisponibles ++;
        NombrePiloto = nombrePiloto;
        PoderPelea = poderPelea;
    }

    public override double GetPoderPelea()
    {
        return PoderPelea;
    }
}

