using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresarNumeros
{
     class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            string linea;
            Console.Write("Ingresa el Primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresa el Segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingresa el tercer número:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingresa el cuarto número:");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;
            Console.Write("La suma de los dos valores es:");
            Console.WriteLine(suma);

            Console.Write("El producto del tercer y cuarto valor es:");
            Console.WriteLine(producto);
            Console.ReadKey();

         
        }
    }
}
