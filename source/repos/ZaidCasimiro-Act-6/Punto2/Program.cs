using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
*/

namespace Punto2
{
    class Cuadrado
    {
        private int lado;

        public void LadoCuadrado()
        {
            Console.Write("Ingrese lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
        }

        public void ImprimirPerimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("El perímetro es: " + perimetro);
        }

        public void ImprimirSuperficie()
        {
            int superficie = lado * lado;
            Console.WriteLine("La superficie es: " + superficie);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado n = new Cuadrado();

            n.LadoCuadrado();
            n.ImprimirPerimetro();
            n.ImprimirSuperficie();

            Console.ReadKey();
        }
    }
}