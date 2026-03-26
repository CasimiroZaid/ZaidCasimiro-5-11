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
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
            valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero. */

            double num = 0, acumulacion = 0;

            while (num != 9999)
            {
                Console.Write("Ingresar valor: ");
                num = double.Parse(Console.ReadLine());
                acumulacion = acumulacion + num;
            }

            if (num == 9999)
            {
                acumulacion = acumulacion - 9999;
                Console.WriteLine("Finalizo la carga");
                Console.WriteLine("Valor acumulado: " + acumulacion);

                if (acumulacion == 0)
                {
                    Console.WriteLine("Valor es cero");
                }

                else if (acumulacion > 0)
                {
                    Console.WriteLine("Valor es mayor a cero");
                }

                else if (acumulacion < 0)
                {
                    Console.WriteLine("Valor es menor a cero");
                }
            }

            Console.ReadKey();
        }
    }
}
