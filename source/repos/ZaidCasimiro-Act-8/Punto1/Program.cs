using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
    del vector.
*/

namespace Punto1
{
    class vector
    {
        private int cantidad = 0;
        private float[] vec;
        private float menor;
        private int repeticiones = 0;

        public void numeroElementos()
        {
            Console.Write("Numero de elementos: ");
            cantidad = int.Parse(Console.ReadLine());
        }

        public void cargarElementos()
        {
            vec = new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingresar elemento: ");
                vec[i] = float.Parse(Console.ReadLine());
            }
        }

        public void imprimirMenor()
        {
            menor = vec[0];

            for (int i = 0; i < vec.Length;i++)
            {
                if (vec[i] < menor)
                {
                    menor = vec[i];
                }
            }

            Console.WriteLine("El menor es: " +  menor);
        }

        public void repeticion()
        {
            for (int i = 0; i < vec.Length;i++)
            {
                if (vec[i] == menor)
                {
                    repeticiones++;
                }
            }

            if (menor > 0)
            {
                Console.WriteLine("El menor aparece " + repeticiones + " veces");
            }
        }

        static void Main(string[] args) 
        {
            vector n = new vector();

            n.numeroElementos();
            n.cargarElementos();
            n.imprimirMenor();
            n.repeticion();

            Console.ReadKey();
        }
    }
}
