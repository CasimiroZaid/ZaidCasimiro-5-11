using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
    (el orden lo pueden elegir ustedes).
*/

namespace Punto3
{
    class vectores
    {
        private int cantidad;
        private int[] vector1;

        public void cantidadElementos()
        {
            Console.Write("Cantidad de elementos: ");
            cantidad = int.Parse(Console.ReadLine());
        }

        public void cargarElementos()
        {
            vector1 = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(" Cargar valor: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ordenamiento()
        {       
            for (int k = 0; k < cantidad; k++)
            {
                for (int j = 0; j < cantidad - 1 - k; j++)
                {
                    if (vector1[j] > vector1[j + 1])
                    {
                        int aux = vector1[j];
                        vector1[j] = vector1[j + 1];
                        vector1[j + 1] = aux;
                    }   
                }
            }

            Console.WriteLine();
            Console.WriteLine("Vector ordenado: De menor a mayor");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(vector1[i]);
            }
        }

        static void Main(string[] args)
        {
            vectores n = new vectores();

            n.cantidadElementos();
            n.cargarElementos();
            n.ordenamiento();

            Console.ReadKey();
        }
    }
}

