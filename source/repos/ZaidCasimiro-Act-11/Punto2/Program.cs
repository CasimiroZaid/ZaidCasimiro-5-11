using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
    primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
    (crearla sin la intervención del operador)
    Realizar la carga por teclado e imprimir posteriormente.
*/

namespace Punto2
{
    class matrizIrregular
    {
        private int[][] matriz;

        public void inicializarMatriz()
        {
            matriz = new int[5][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[i + 1];
            }
        }

        public void cargarDatos()
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("Fila " + (i + 1) + " (ingresa " + (matriz[i].Length) + " valores):");

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write("Ingrese dato: ");
                    matriz[i][j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Matriz Irregular");

            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write(matriz[f][c] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matrizIrregular n = new matrizIrregular();

            n.inicializarMatriz();
            n.cargarDatos();
            n.imprimir();

            Console.ReadKey();
        }
    }
}