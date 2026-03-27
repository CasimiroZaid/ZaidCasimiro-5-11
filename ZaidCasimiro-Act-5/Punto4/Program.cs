using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. Se cuenta con la siguiente información:
                ● Las edades de 20 estudiantes del turno mañana.
                ● Las edades de 30 estudiantes del turno tarde.
                ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
                a) Obtener el promedio de las edades de cada turno (tres promedios)
                b) Imprimir dichos promedios (promedio de cada turno)
                c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
                promedio de edades menor.*/
                       
            double promm, promt, promn, totalm = 0, totalt = 0, totaln = 0;
            int edad;

            Console.WriteLine("Turno mañana");

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingresar la edad del estudiante (" + (i + 1) + "): ");
                edad = int.Parse(Console.ReadLine());
                
                totalm += edad;
            }

            Console.WriteLine("Turno tarde");

            for (int i = 0; i < 30; i++)
            {
                Console.Write("Ingresar la edad del estudiante (" + (i + 1) + "): ");
                edad = int.Parse(Console.ReadLine());

                totalt += edad;
            }

            Console.WriteLine("Turno noche");

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingresar la edad del estudiante (" + (i + 1) + "): ");
                edad = int.Parse(Console.ReadLine());

                totaln += edad;
            }

            promm = totalm / 20;
            promt = totalt / 30;
            promn = totaln / 15;

            Console.WriteLine("Promedio de edad en turno mañana: " + promm);
            Console.WriteLine("Promedio de edad en turno tarde: " + promt);
            Console.WriteLine("Promedio de edad en turno noche: " + promn);

            if (promm < promt && promm < promn)
            {
                Console.WriteLine("Turno mañana tiene el promedio de edad menor");
            }

            else if (promt < promm && promt < promn)
            {
                Console.WriteLine("Turno tarde tiene el promedio de edad menor");
            }

            else
            {
                Console.WriteLine("Turno noche tiene el promedio de edad menor");
            }

            Console.ReadKey();
        }
    }
}
