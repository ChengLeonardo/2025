namespace Biblioteca;

public class Categoria
{
    public int categoria { get; set; }
    public double Dureza { get; set; }
    public double Vida { get; set; }
    public double Energia { get; set; }
    public Categoria(int categoria, double dureza, double Vida, double Energia) 
    {
        this.categoria = categoria;
        this.Dureza = dureza;
        this.Vida = Vida;
        this.Energia = Energia;
    }
}