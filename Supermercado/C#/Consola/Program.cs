// See https://aka.ms/new-console-template for more information
using Biblioteca;
Tienda tienda = new Tienda();

string[] opciones = { "1", "2", "3", "4", "5" };
Console.WriteLine("Bienvenido a la tienda");
Console.WriteLine("1. Agregar producto");
Console.WriteLine("2. Eliminar producto");
Console.WriteLine("3. Modificar producto");
System.Console.WriteLine("4. Mostrar productos");
Console.WriteLine("5. Salir");
System.Console.WriteLine("Seleccione una opcion: ");
string opcion = Console.ReadLine();
while(opcion != "5")
{
    string nombre = "";
    try{

    
    switch(opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese el precion unitario: ");
            decimal PrecioUnitario = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el stock: ");
            int stock = int.Parse(Console.ReadLine());
            Producto producto = new Producto(nombre, PrecioUnitario, stock);
            tienda.AgregarProducto(producto);
            System.Console.WriteLine("Producto agregado correctamente.");
            System.Console.WriteLine("==========================");
            
            break;
        case "2":
            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();
            if (nombre != null)
            {
                tienda.EliminarProducto(nombre);
                System.Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                System.Console.WriteLine("El producto no existe en la tienda.");
            }
            break;
        case "3":
            Console.WriteLine("Ingrese el nombre del producto:");
            nombre = Console.ReadLine();
            Producto productoModificar = tienda.Productos.FirstOrDefault(p => p.Nombre == nombre);
            if (productoModificar != null)
            {
                System.Console.WriteLine("Ingrese el nuevo nombre del producto:");
                string nuevoNombre = Console.ReadLine();
                System.Console.WriteLine("Ingrese el nuevo precio unitario del producto:");
                decimal nuevoPrecioUnitario = decimal.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese el nuevo stock del producto:");
                int nuevoStock = int.Parse(Console.ReadLine());
                tienda.ModificarProducto(productoModificar, nuevoNombre, nuevoPrecioUnitario, nuevoStock);
                System.Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                System.Console.WriteLine("El producto no existe en la tienda.");
            }
            break;
        case "4":
            System.Console.WriteLine("Productos en la tienda:");
            tienda.MostrarProductos();
            break;
        case "5":
            System.Console.WriteLine("Saliendo de la tienda...");
            return;
        default:
            System.Console.WriteLine("Opcion no valida, por favor intetntet nuevamente.");
            break;
    }
    Task.Delay(2000).Wait();

    Console.WriteLine("Bienvenido a la tienda");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Eliminar producto");
    Console.WriteLine("3. Modificar producto");
    System.Console.WriteLine("4. Mostrar productos");
    Console.WriteLine("5. Salir");
    System.Console.WriteLine("Seleccione una opcion: ");

    opcion = Console.ReadLine();
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
        System.Console.WriteLine("Ocurrio un error, por favor intente nuevamente.");
        System.Console.WriteLine("==========================");
    }
}