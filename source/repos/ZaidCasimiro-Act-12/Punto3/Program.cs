using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Academia de Gastronomía: Recetario Dinámico
    Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
    una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
        ● Definir un vector para los nombres de los alumnos.
        ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
        presentado.
        ● Métodos:
            1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
            de cada alumno.
            2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
            3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
            4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado"
            (promedio >= 70) o "Reprobado".
            5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
            valor máximo de la matriz).
*/

namespace Punto3
{
    class academia
    {
        private string[] nombres;
        private int[][] puntajes;

        public void inicializar()
        {
            nombres = new string[3];
            puntajes = new int[3][];
            puntajes[0] = new int[2];
            puntajes[1] = new int[4];
            puntajes[2] = new int[3];

            Console.WriteLine("Cargar nombres de los alumnos");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Cargar nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine();
            }
        }

        public void cargarPuntaje()
        {
            int nota = -1;

            Console.WriteLine("\nCargar puntajes de los platos");

            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.WriteLine($"\nPlatos de {nombres[i]}:");

                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    while (nota < 0 || nota > 100)
                    {
                        Console.Write($"Cargar puntaje del plato {j + 1}: ");
                        nota = int.Parse(Console.ReadLine());

                        if (nota < 0 || nota > 100)
                        {
                            Console.WriteLine("Puntaje invalido, fuera del rango (0 - 100). Intente nuevamente");
                        }
                    }

                    puntajes[i][j] = nota;
                    nota = -1;
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("\nListado de alumnos y sus puntajes:");
            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.WriteLine($"\nAlumno: {nombres[i]}");
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.WriteLine($"Plato {j + 1}: {puntajes[i][j]} puntos");
                }
            }
        }

        public void calcularPromedios()
        {
            for (int i = 0; i < puntajes.Length; i++)
            {
                double suma = 0;
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    suma += puntajes[i][j];
                }

                double promedio = suma / puntajes[i].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine($"{nombres[i]}: Promedio {promedio} Aprobado");
                }
                else
                {
                    Console.WriteLine($"{nombres[i]}: Promedio {promedio} Reprobado");
                }
            }
        }

        public void puntajeMasAlto()
        {
            int maxPuntaje = -1;
            string alumnoMax = "";

            for (int i = 0; i < puntajes.Length; i++)
            {
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    if (puntajes[i][j] > maxPuntaje)
                    {
                        maxPuntaje = puntajes[i][j];
                        alumnoMax = nombres[i];
                    }
                }
            }

            Console.WriteLine($"\nEl puntaje individual más alto fue de {maxPuntaje} puntos, obtenido por el alumno: {alumnoMax}");
        }

        static void Main(string[] args)
        {
            academia academia1 = new academia();

            academia1.inicializar();
            academia1.cargarPuntaje();
            academia1.imprimir();
            academia1.calcularPromedios();
            academia1.puntajeMasAlto();

            Console.WriteLine("\nPresionar cualquier tecla para salir del programa");
            Console.ReadKey();
        }
    }
}