using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    ordenado de menor a mayor y de mayor a menor.
*/

namespace Punto4
{
    class verificacion
    {
        private float[] vector;
        private bool ascendente = true;
        private bool descendente = true;

        public void ingresarElementos()
        {
            vector = new float[10];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingresar elemento: ");
                vector[i] = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        public void verificarAsc()
        {
            for (int i = 0;i < vector.Length - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    ascendente = false;
                    break;
                }
            }
        }

        public void verificarDes()
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] < vector[i + 1])
                {
                    descendente = false;
                    break;
                }
            }
        }

        public void verificar()
        {
            if (ascendente)
            {
                Console.WriteLine("El vector esta ordenado de menor a mayor");
            }

            if (descendente)
            {
                Console.WriteLine("El vector esta ordenado de mayor a menor");
            }
            if (!ascendente && !descendente)
            {
                Console.WriteLine("El vector no tiene orden");
            }
        }

        static void Main(string[] args)
        {
            verificacion n = new verificacion();

            n.ingresarElementos();
            n.verificarAsc();
            n.verificarDes();
            n.verificar();

            Console.ReadKey();
        }
    }
}
