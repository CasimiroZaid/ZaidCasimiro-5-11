using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZaid
{
    internal class Punto2
    {
        static void Main(string[] args)
        {
            //2.Escribir un programa en el cual se ingresen cuatro números, calcular e
            //informar la suma de los dos primeros y el producto del tercero y el cuarto. 
                    
            int num1, num2, num3, num4, suma, producto;
            string linea;

            Console.WriteLine("El primer y segundo valor se suman y el tercer y cuarto valor se multiplican");

            Console.Write("Ingresar valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresar valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingresar valor del tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingresar valor del cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            Console.WriteLine("los Valores son:    1er = " + num1 + "  / 2do = " + num2 + "  / 3er = " + num3 + "  / 4to = " + num4);

            suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);

            producto = num3 * num4;q
            Console.WriteLine("El producto es: " + producto);

            Console.ReadKey();
        }
    }
}
   