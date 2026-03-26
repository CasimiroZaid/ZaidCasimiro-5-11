using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            int num1, num2, num3, num4, suma;

            double promedio;

            string linea;

            Console.WriteLine("Se sumaran los cuatro valores y luego se mostrara su promedio");

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

            suma = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma es: " + suma);

            promedio = (num1 + num2 + num3 + num4) / 4.0;
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}
    