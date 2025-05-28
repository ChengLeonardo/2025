using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ticket
    {
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<ItemTicket> items;

        public decimal Total { get; private set; }
        public Ticket()
        {
            items = new List<ItemTicket>();
            Total = 0;
        }
        public void AgregarItem(ItemTicket item)
        {
            items.Add(item);
            Total += item.Subtotal;
        }
        public void QuitarItem(ItemTicket item)
        {
            if (items.Remove(item))
            {
                Total -= item.Subtotal;
            }
        }
        public void Limpiar()
        {
            items.Clear();
            Total = 0;
        }

        public void InformacionTicket()
        {
            
            System.Console.WriteLine("Ticket:");
            System.Console.WriteLine($"Cliente: {Cliente.Nombre} {Cliente.Apellido}");
            System.Console.WriteLine($"Fecha: {Fecha.ToString("dd/MM/yyyy HH:mm")}");
            foreach (var item in items)
            {
                System.Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Precio Unitario: {item.PrecioUnitario:C}, Subtotal: {item.Subtotal:C}");
            }
            System.Console.WriteLine($"Total: {Total:C}");
        }
    }
}