using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos

            int num1, num2, num3, mayor;
            string linea;

            Console.Write("Ingresar prmier numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresar prmier numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingresar prmier numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine("El mayor es: " + mayor);

            Console.ReadKey();
        }
    }
}
