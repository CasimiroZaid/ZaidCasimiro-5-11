using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Escribir un programa que lea el peso(en kilogramos) y la altura(en metros) de una persona, y mostrar por 
            //pantalla su índice de masa corporal(IMC)(El IMC se calcula dividiendo el peso entre el cuadrado de la altura).

            double peso, altura, imc;
            string linea;

            Console.Write("Ingresar el peso: ");
            linea = Console.ReadLine();
            peso = double.Parse(linea);

            Console.Write("Ingresar la altura: ");
            linea = Console.ReadLine();
            altura = double.Parse(linea);

            imc = peso / (altura * altura);
            Console.WriteLine("Indice de masa corporal (IMC): " + imc);

            Console.ReadKey();

        }
    }
}
