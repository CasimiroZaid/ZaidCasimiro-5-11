using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
calcular su suma, resta, multiplicación y división, cada una en un método,
imprimir dichos resultados.
*/

namespace Punto4
{
    class Operaciones
    {
        private int valor1;
        private int valor2;

        public void CargarDatos()
        {
            Console.Write("Ingrese el primer valor entero: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor entero: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void Sumar()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("La suma es: " + suma);
        }

        public void Restar()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("La resta es: " + resta);
        }

        public void Multiplicar()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicación es: " + multiplicacion);
        }

        public void Dividir()
        {
                int division = valor1 / valor2;
                Console.WriteLine("La división es: " + division);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones calcular = new Operaciones();

            calcular.CargarDatos();
            calcular.Sumar();
            calcular.Restar();
            calcular.Multiplicar();
            calcular.Dividir();

            Console.ReadKey();
        }
    }
}