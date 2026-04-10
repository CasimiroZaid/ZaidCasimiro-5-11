using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    tercer vector del mismo tamaño. Sumar componente a componente.
*/

namespace Punto2
{
    class vectores
    {
        private float[] vector1;
        private float[] vector2;
        private float[] vector3;

        public void cargaVector1()
        {
            vector1 = new float[4];

            Console.WriteLine("Ingresar 4 elementos para el primer vector: ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();

                Console.Write("Ingresar elemento: ");
                vector1[i] = float.Parse(Console.ReadLine());
            }
        }

        public void cargaVector2()
        {
            vector2 = new float[4];

            Console.WriteLine();
            Console.WriteLine("Ingresar 4 elementos para el segundo vector: ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();

                Console.Write("Ingresar elemento: ");
                vector2[i] = float.Parse(Console.ReadLine());
            }
        }

        public void sumarVectores()
        {
            vector3 = new float[4];

            for (int i = 0;i < 4;i++)
            {
                vector3[i] = vector1[i] + vector2[i];
                Console.WriteLine("La suma de los dos vectores en la posicon (" + i + ") es: " + vector3[i]);
            }
        }

        static void Main(string[] args)
        {
            vectores n = new vectores();

            n.cargaVector1();
            n.cargaVector2();
            n.sumarVectores();

            Console.ReadKey();
        }
    }
}
