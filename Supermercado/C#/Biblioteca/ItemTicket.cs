namespace Biblioteca;
public class ItemTicket
{
    public Producto Producto { get; set; }
    public decimal PrecioUnitario { get; init; }
    public int Cantidad { get; init; }
    public decimal Subtotal { get; init; }

    public ItemTicket(Producto producto, int Cantidad)
    {
        Producto = producto;
        PrecioUnitario = producto.PrecioUnitario;
        this.Cantidad = Cantidad;
        Subtotal = PrecioUnitario * Cantidad;
    }
}