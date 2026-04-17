using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
    algoritmo de ordenamiento alfabético.
*/

namespace Punto2
{
    class vector 
    {
        private string[] paises;

        public void cargarPaises()
        {
            paises = new string[5];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Nombre del pais: ");
                paises[i] = Console.ReadLine();

            }
        }

        public void ordenamiento()
        {
            string aux;

            for (int k = 0; k < paises.Length; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        static void Main(string[] args)
        {
            vector n = new vector();

            n.cargarPaises();
            n.ordenamiento();

            Console.ReadKey();
        }
    }
}
