using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

/*  4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
    ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    nuevamente.
*/

namespace Punto4
{
    class vectores
    {
        private string[] paises;
        private int[] habitantes;

        public void cargarPaises()
        {
            paises = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre del pais " + (i + 1) + ": ");
                paises[i] = Console.ReadLine();
            }
        }

        public void cargarHabitantes()
        {
            habitantes = new int[5];

            Console.WriteLine();
            Console.WriteLine("Cantidad de habitantes:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("De " + paises[i] + ": ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ordenamientoAlfabetico()
        {
            string auxP;

            Console.WriteLine();

            for (int k = 0; k < paises.Length; k++)
            {
                for (int j = 0; j < paises.Length - 1 - k; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        auxP = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxP;
                    }
                }
            }

            Console.WriteLine("Ordenado alfabeticamente:");

            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        public void ordenamientoNumerico()
        {
            int auxH;

            Console.WriteLine();

            for (int k = 0; k < habitantes.Length; k++)
            {
                for (int j = 0; j < habitantes.Length - 1 - k; j++)
                {
                    if (habitantes[j] < habitantes[j + 1])
                    {
                        auxH = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxH;
                    }
                }
            }

            Console.WriteLine("Ordenado por cantidad de habitantes de mayor a menor:");

            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine(habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            vectores n = new vectores();

            n.cargarPaises();
            n.cargarHabitantes();
            n.ordenamientoAlfabetico();
            n.ordenamientoNumerico();

            Console.ReadLine();
        }
    }
}
