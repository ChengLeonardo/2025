namespace Biblioteca
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public Tienda()
        {
        }
        public void AgregarProducto(Producto producto)
        {
            if(Productos.Any(p => p.Nombre == producto.Nombre))
            {
                throw new Exception("El producto ya existe en la tienda.");
            }
            if(producto == null)
            {
                throw new Exception("nulo");
            }
            Productos.Add(producto);
        }

        public void EliminarProducto(string nombre)
        {
            if (!Productos.Any(p => p.Nombre == nombre))
            {
                throw new Exception("El producto no existe en la tienda.");
            }
            Productos.Remove(Productos.FirstOrDefault(p => p.Nombre == nombre));
        }
        public void ModificarProducto(Producto producto, string nuevoNombre, decimal nuevoPrecioUnitario, int nuevoStock)
        {
            if (!Productos.Any(p => p.Nombre == producto.Nombre))
            {
                throw new Exception("El producto no existe en la tienda.");
            }
            producto.Nombre = nuevoNombre ?? producto.Nombre;
            producto.PrecioUnitario = nuevoPrecioUnitario;
            producto.Stock = nuevoStock;
        }
        public void MostrarProductos()
        {
            foreach (var producto in Productos)
            {
                System.Console.WriteLine($"Nombre: {producto.Nombre}, Precio Unitario: {producto.PrecioUnitario}, Stock: {producto.Stock}");
            }

            Console.WriteLine("");
        }
    }
}