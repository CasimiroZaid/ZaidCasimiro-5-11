using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su
            //suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.

            double division,num1, num2, suma, diferencia, producto;;
            string linea;

            Console.Write("Ingresar primer valor: ");
            linea = Console.ReadLine();
            num1 = double.Parse(linea);

            Console.Write("Ingresar segundo valor: ");
            linea = Console.ReadLine();
            num2 = double.Parse(linea);

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor al segundo");

                suma = num1 + num2;
                Console.WriteLine("La suma es: " + suma);

                diferencia = num1 - num2;
                Console.WriteLine("La diferencia es: " + diferencia);
            }
            else
            {
                Console.WriteLine("El primer numero es menor al segundo");

                producto = num1 * num2;
                Console.WriteLine("El producto es: " + producto);

                division = num1 / num2;
                Console.WriteLine("La division es: " + division);
            }

            Console.ReadKey();

        }
    }
}
