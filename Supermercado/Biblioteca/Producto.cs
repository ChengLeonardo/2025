

namespace Biblioteca;

public class Producto
{
    public string  Nombre { get; set; }
    public decimal PrecioUnitario { get; set; }
    public int Stock { get; set; }

    public Producto(string nombre, decimal PrecioUnitario, int Stock)
    {
        this.Nombre = nombre;
        this.PrecioUnitario = PrecioUnitario;
        this.Stock = Stock;
    }
}