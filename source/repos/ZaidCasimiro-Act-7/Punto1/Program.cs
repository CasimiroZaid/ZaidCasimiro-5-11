using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        El valor acumulado de todos los elementos del vector.
        El valor acumulado de los elementos del vector que sean mayores a 36.
        Cantidad de valores mayores a 50.
*/

namespace Punto1
{
    class vectores
    {
        private float[] elementos;

        public void ingresarElementos()
        {
            elementos = new float[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Infresar elemento numerico para el vector: ");
                elementos[i] = float.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }

        public void valorAcumuladoTotal()
        {
            float total = 0;

            for (int i = 0;i < elementos.Length;i++)
            {
                total += elementos[i];
            }

            Console.WriteLine("Valor total de todos los elementos: " + total);
        }

        public void valorTotalMayor36()
        {
            float total = 0;

            for (int i = 0;i < elementos.Length ; i++)
            {
                if (elementos[i] > 36)
                {
                    total += elementos[i];
                }
            }

            Console.WriteLine("Valor total de los elementos mayores a 36: "+ total);
        }

        public void valoresMayor50()
        {
            int cantidad = 0;

            for (int i = 0;i < elementos.Length ;i++)
            {
                if (elementos[i] > 50)
                {
                    cantidad++;
                }
            }

            Console.WriteLine("Cantidad de valores mayores a 50: " + cantidad);
        }
        static void Main(string[] args)
        {
            vectores n = new vectores();

            n.ingresarElementos();
            n.valorAcumuladoTotal();
            n.valorTotalMayor36();
            n.valoresMayor50();

            Console.ReadKey();
        }
    }
}
