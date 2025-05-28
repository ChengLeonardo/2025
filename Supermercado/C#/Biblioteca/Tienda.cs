namespace Biblioteca;

    public class Tienda
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
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

        public void Vender(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new Exception("El ticket no puede ser nulo.");
            }

            Task[] sacarStockTask = new Task[ticket.items.Count];
            for (int i = 0; i < ticket.items.Count; i++)
            {
                var item = ticket.items[i];
                var producto = Productos.FirstOrDefault(p => p.Nombre == item.Producto.Nombre);
                
                if (producto == null)
                {
                    throw new Exception($"El producto {item.Producto.Nombre} no existe en la tienda.");
                }
                
                if (producto.Stock < item.Cantidad)
                {
                    throw new Exception($"No hay suficiente stock para el producto {item.Producto.Nombre}. Stock disponible: {producto.Stock}");
                }

                sacarStockTask[i] = Task.Run(() => producto.Stock -= item.Cantidad);
            }
            Task.WaitAll(sacarStockTask);
            ticket.Fecha = DateTime.Now;
            Tickets.Add(ticket);
        }
        public bool ClienteExiste(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new Exception("El cliente no puede ser nulo.");
            }
            if (!Clientes.Any(c => c.Nombre == cliente.Nombre && c.Apellido == cliente.Apellido))
            {
                return false;
            }
            return true;
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new Exception("El cliente no puede ser nulo.");
            }
            if (Clientes.Any(c => c.Nombre == cliente.Nombre && c.Apellido == cliente.Apellido))
            {
                throw new Exception("El cliente ya existe en la tienda.");
            }
            Clientes.Add(cliente);
        }
}