using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad. */

            int triangulos, lado1, lado2, lado3, equilateros = 0, isoceles = 0, escalenos = 0;

            Console.Write("Cantidad de triangulos: ");
            triangulos = int.Parse(Console.ReadLine());

            for (int i = 0; i < triangulos; i++)
            {
                Console.Write("Ingresar primer lado : ");
                lado1 = int.Parse(Console.ReadLine());

                Console.Write("Ingresar segundo lado: ");
                lado2 = int.Parse(Console.ReadLine());

                Console.Write("Ingresar tercer lado: ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3)
                {
                    equilateros++;
                    Console.WriteLine("Equilatero");
                }

                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    isoceles++;
                    Console.WriteLine("Isoceles");
                }

                else
                {
                    escalenos++;
                    Console.WriteLine("Escaleno");
                }

            }

            Console.WriteLine("Cantidad de equilateros: " + equilateros);
            Console.WriteLine("Cantidad de isoceles: " + isoceles);
            Console.WriteLine("Cantidad de escalenos: " + escalenos);

            if (equilateros > isoceles && equilateros > escalenos)
            {
                Console.WriteLine("Hay mas triangulso equilateros");
            }

            else if (isoceles > equilateros && isoceles > escalenos)
            {
                Console.WriteLine("Hay mas triangulos isoceles");
            }

            else
            {
                Console.WriteLine("Hay mas escalenos");
            }

            Console.ReadKey();
        }
    }
}
