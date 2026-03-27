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
            /* 3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
                a) La cantidad de valores ingresados negativos.
                b) La cantidad de valores ingresados positivos.
                c) La cantidad de múltiplos de 15.
                d) El valor acumulado de los números ingresados que son pares. */

            int num, neg = 0, pos = 0, multi = 0, valort = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingresar valor: ");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    neg++;
                }

                if (num > 0)
                {
                    pos++;
                }

                if (num % 15 == 0)
                {
                    multi++;
                }

                if (num % 2 == 0)
                {
                    valort += num;
                }
            }

            Console.WriteLine("Cantidad de negativos: " +  neg);
            Console.WriteLine("Cantidad de positivos: " + pos);
            Console.WriteLine("Cantidad de multiplos de 15: " + multi);
            Console.WriteLine("Valor acumulado de los numeros pares: " +  valort);

            Console.ReadKey();
        }
    }
}
