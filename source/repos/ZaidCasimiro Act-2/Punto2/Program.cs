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
            //2.Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"

            int nota1, nota2, nota3, nota4, nota5, nota6;
            double promedio;
            string linea;

            Console.Write("Ingresar la primera nota: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);

            Console.Write("Ingresar la segunda nota: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);

            Console.Write("Ingresar la tercera nota: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            Console.Write("Ingresar la cuarta nota: ");
            linea = Console.ReadLine();
            nota4 = int.Parse(linea);

            Console.Write("Ingresar la quinta nota: ");
            linea = Console.ReadLine();
            nota5 = int.Parse(linea);

            Console.Write("Ingresar la sexta nota: ");
            linea = Console.ReadLine();
            nota6 = int.Parse(linea);

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;
            Console.WriteLine("Promedio de notas: " + promedio);

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                Console.WriteLine("No promocionado");
            }

            Console.ReadKey();
        }
    }
}
