using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
    asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
            1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
            intervención del operador).
            2. Crear un método de "Venta de Entradas" que permita cargar la edad del
            espectador en un asiento específico (fila y columna).
            3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
            en cada asiento.
            4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
            5. Informar cuál es el promedio de edad de los espectadores de todo el
            complejo.
*/

namespace Punto2
{
    class cine
    {
        private int[][] salas;

        public void inicializar()
        {
            salas = new int[4][];
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }

        public void ventaDeEntradas()
        {
            string continuar = "y";

            Console.WriteLine("Venta de entradas");

            while (continuar == "y")
            {
                Console.Write("\nIngrese la sala (1 - 4): ");
                int sala = int.Parse(Console.ReadLine());

                Console.Write($"Ingrese el asiento (1 - {salas[sala - 1].Length}): ");
                int asiento = int.Parse(Console.ReadLine());

                Console.Write("Ingresar edad del espectador: ");
                int edad = int.Parse(Console.ReadLine());

                salas[sala - 1][asiento - 1] = edad;

                Console.Write("Otra entrada (y / n)?: ");
                continuar = Console.ReadLine();
            }
        }

        public void imprimir()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                Console.Write($"\nSala {i + 1} ({salas[i].Length} asientos): ");

                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0)
                    {
                        Console.Write($"[ {salas[i][j]} ]");
                    }
                    else
                    {
                        Console.Write($"[ - ]");
                    }
                }
            }
            Console.WriteLine();
        }

        public void calcularMenores()
        {
            int menores;

            for (int i = 0; i < salas.Length; i++)
            {
                menores = 0;

                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] < 18 && salas[i][j] > 0)
                    {
                        menores += 1;
                    }
                }

                Console.WriteLine($"\nMenores de 18 años en la sala {i + 1}: {menores}");
            }
        }

        public void promedioEdad()
        {
            int total = 0;
            int totalEspectadores = 0;

            for (int i = 0; i < salas.Length; i++)
            {
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0)
                    {
                        total += salas[i][j];
                        totalEspectadores += 1;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            cine cine1 = new cine();

            cine1.inicializar();
            cine1.ventaDeEntradas();
            cine1.imprimir();
            cine1.calcularMenores();
            cine1.promedioEdad();

            Console.WriteLine("\nTocar cualquier tecla para salir del programa");
            Console.ReadKey();
        }
    }
}