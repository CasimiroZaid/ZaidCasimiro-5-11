using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
    empresa.
    Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
    irregular para cargar los días que han faltado cada empleado (cargar el número de día que
    faltó)
    Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.
*/

namespace Punto3
{
    class diasFaltas
    {
        private string[] nombres;
        private int[][] diasFaltados;

        public void cargarDatos()
        {
            nombres = new string[3];
            diasFaltados = new int[3][];

            int cantfaltas = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Cargar nombre {i +1}: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine();

                Console.Write($"Cuantos dias falto {nombres[i]}: ");
                cantfaltas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                diasFaltados[i] = new int[cantfaltas];

                for (int j = 0; j < diasFaltados[i].Length; j++)
                {
                    Console.Write($"Dia que falto{j + 1}: ");
                    diasFaltados[i][j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }
        }

        public void imprimir()
        {
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Empleado: {nombres[i]} / Falto: {diasFaltados[i].Length}");

                if (diasFaltados[i].Length > 0)
                {
                    Console.Write("Días que falto: ");
                    for (int j = 0; j < diasFaltados[i].Length; j++)
                    {
                        Console.Write($"{diasFaltados[i][j]}, ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            diasFaltas n = new diasFaltas();

            n.cargarDatos();
            n.imprimir();

            Console.ReadKey();
        }
    }
}
