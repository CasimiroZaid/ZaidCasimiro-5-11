using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

/*  2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
    constructor, calcular su suma, resta, multiplicación y división, cada una en un
    método, imprimir dichos resultados.
*/

namespace Punto2
{
    class operaciones
    {
        private int valor1;
        private int valor2;

        private int suma = 0;

        private int resta1 = 0;
        private int resta2 = 0;

        private int multiplicacion = 0;

        private int division1 = 0;
        private int division2 = 0;

        public operaciones()
        {
            Console.Write("Cargar 1er valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Cargar 2do valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void sumar()
        {
            suma = valor1 + valor2;
        }

        public void restar()
        {
            resta1 = valor1 - valor2;
            resta2 = valor2 - valor1;
        }

        public void multiplicar()
        {
            multiplicacion = valor1 * valor2;
        }

        public void dividir()
        {
            division1 = valor1 / valor2;
            division2 = valor2 / valor1;
        }

        public void imprimir()
        {
            Console.WriteLine($"\nOperaciones con los valores: {valor1} y {valor2}");

            Console.WriteLine($"Suma:\n{suma}\n");
            Console.WriteLine($"Resta:\n{valor1} - {valor2}: {resta1}\n{valor2} - {valor1}: {resta2}\n");
            Console.WriteLine($"Multiplicacion:\n{multiplicacion}\n");
            Console.WriteLine($"Division:\n{valor1} - {valor2}: {division1}\n{valor2} - {valor1}: {division2}\n");
        }

        static void Main(string[] args)
        {
            operaciones op = new operaciones();

            op.sumar();
            op.restar();
            op.multiplicar();
            op.dividir();
            op.imprimir();

            Console.ReadKey();
        }
    }
}


