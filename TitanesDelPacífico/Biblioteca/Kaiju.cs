namespace Biblioteca;

public class Kaiju : Pelea
{
    public List<Habilidad> habilidades;
    public Categoria categoria;
    public ETamanio eTamanio;
    public bool Vuela = false;
    public static DateTime SiguienteAparicion;
    public static int Ola;
    public Kaiju(List<Habilidad> habilidades, Categoria categoria, ETamanio eTamanio)
    {
        this.habilidades = habilidades;
        this.categoria = categoria;
        this.eTamanio = eTamanio;
    }

    public double CalcularSumatoriaDanioHabilidades()
    {
        double sumatioriaDanioHabilidades = habilidades.Sum(h => h.Danio);
        return sumatioriaDanioHabilidades;
    }
    public override double GetPoderPelea()
    {
        double poderPelea = 0;
        double sumatioriaDanioHabilidades = CalcularSumatoriaDanioHabilidades();
        poderPelea = categoria.Energia * sumatioriaDanioHabilidades;
        return poderPelea;
    }

}