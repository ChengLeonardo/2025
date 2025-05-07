namespace Biblioteca;

public class Habilidad
{
    public string Descripcion;
    public string Nombre { get; set; }
    public double Danio{ get; set; }

    public Habilidad(string Descripcion, double Danio, string Nombre)
    {
        this.Nombre = Nombre;  
        this.Danio = Danio;
        this.Descripcion = Descripcion;
    }
}