using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del
            //mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int num1, num2;
            string linea;

            Console.WriteLine("El valor es el lado de un cuardaro y se conseguira el perimetro");

            Console.Write("Ingresar valor para lado de un cuadrado: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            num2 = num1 * 4;
            Console.Write("El perimetro es de: ");
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
