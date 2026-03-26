using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Se debe desarrollar un programa que pida el ingreso del precio de un artículo
            //y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int num1;
            decimal num2, abonar;
            string linea;

            Console.WriteLine("Se mostrara el precio total");

            Console.Write("Ingresar el precio del articulo: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresar cantidad para llevar: ");
            linea = Console.ReadLine();
            num2 = decimal.Parse(linea);

            abonar = num1 * num2;
            Console.WriteLine("El total a abonar es de: " + abonar);

            Console.ReadKey();

        }
    }
}
