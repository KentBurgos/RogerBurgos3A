using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Clases;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Identificacion: ");
            cliente.Identificacion = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            cliente.Nombre = Console.ReadLine();

            cliente.

            Reserva reserva = new Reserva();
            Console.WriteLine("Numero de reserva: ");
            reserva.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha: ");
            reserva.Fecha = Console.ReadLine();

 
            Console.WriteLine("Total: ");
            reserva.Total = int.Parse(Console.ReadLine());


            Habitacion habitacion = new Habitacion();
            Console.WriteLine("Numero de Habitacion: ");
            habitacion.Numero = Console.ReadLine();

            //ServiciosExtra servicios = new ServiciosExtra();
      //      Console.WriteLine("Agregar servicios extras: ");
        //    reserva.Servicios = Console.ReadLine();



            Console.WriteLine("Identificacion: " +cliente.Identificacion);
            Console.WriteLine("Nombre: " +cliente.Nombre);
            Console.WriteLine("Reserva #" +reserva.Numero);
            Console.WriteLine("Fecha: " +reserva.Fecha);
            Console.WriteLine("Numero de Habitacion: "+habitacion.Numero);
            Console.WriteLine("Detalles del servicios adicionales: ");


            Console.ReadKey();

        }
    }
}
