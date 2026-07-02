using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Plantear una clase Club y otra clase Socio.
    La clase Socio debe tener los siguientes atributos privados: nombre y la
    antigüedad en el club (en años). En el constructor pedir la carga del nombre y
    su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
    Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
    antigüedad en el club.*/

namespace Punto3
{
    class socio
    {
        private string nombre;
        private int antiguedad;

        public socio()
        {
            Console.Write("Ingrese el nombre del socio: ");
            nombre = Console.ReadLine();

            Console.Write($"Ingrese la antigüedad de {nombre}: ");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public int retornarAntiguedad()
        {
            return antiguedad;
        }
    }

    class club
    {
        private socio socio1;
        private socio socio2;
        private socio socio3;

        public club()
        {
            Console.WriteLine("Carga del Socio 1:");
            socio1 = new socio();

            Console.WriteLine("Carga del Socio 2:");
            socio2 = new socio();

            Console.WriteLine("Carga del Socio 3:");
            socio3 = new socio();
        }

        public void mayorAntiguedad()
        {
            Console.WriteLine("Socio con mayor antigüedad:");

            if (socio1.retornarAntiguedad() > socio2.retornarAntiguedad() && socio1.retornarAntiguedad() > socio3.retornarAntiguedad())
            {
                Console.WriteLine(socio1.retornarNombre());
            }
            else
            {
                if (socio2.retornarAntiguedad() > socio3.retornarAntiguedad())
                {
                    Console.WriteLine(socio2.retornarNombre());
                }
                else
                {
                    Console.WriteLine(socio3.retornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            club c = new club();
            c.mayorAntiguedad();

            Console.ReadKey();
        }
    }
}