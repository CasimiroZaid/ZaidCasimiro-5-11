using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
    vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
    alumno y sus 4 calificaciones.
    Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
    Alumno.
    Agregar los siguientes métodos:
    a) Un método que imprima el nombre de cada alumno y su promedio.
    b) Un método que muestre el nombre del alumno con el promedio más alto.
    c) Un método que indique qué alumnos tienen al menos una nota desaprobada (nota menor a 6)*/

namespace Punto4
{
    class alumno
    {
        private string nombre;
        private int[] notas;

        public alumno()
        {
            Console.Write("Nombre del alumno: ");
            nombre = Console.ReadLine();

            notas = new int[4];
            for (int f = 0; f < 4; f++)
            {
                Console.Write($"Ingrese nota {f + 1}: ");
                notas[f] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public double calcularPromedio()
        {
            int suma = 0;
            for (int f = 0; f < 4; f++)
            {
                suma = suma + notas[f];
            }
            return (double)suma / 4;
        }

        public bool tieneDesaprobada()
        {
            for (int f = 0; f < 4; f++)
            {
                if (notas[f] < 6)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class curso
    {
        private alumno[] alumnos;

        public curso()
        {
            alumnos = new alumno[3];
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine($"Carga del alumno {f + 1}:");
                alumnos[f] = new alumno();
            }
        }

        public void imprimirPromedios()
        {
            Console.WriteLine("Alumnos y sus promedios:");
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine($"{alumnos[f].retornarNombre()} tiene un promedio de: {alumnos[f].calcularPromedio()}");
            }
            Console.WriteLine();
        }

        public void promedioMasAlto()
        {
            double mayorPromedio = alumnos[0].calcularPromedio();
            string nombreMayor = alumnos[0].retornarNombre();

            for (int f = 1; f < 3; f++)
            {
                if (alumnos[f].calcularPromedio() > mayorPromedio)
                {
                    mayorPromedio = alumnos[f].calcularPromedio();
                    nombreMayor = alumnos[f].retornarNombre();
                }
            }
            Console.WriteLine($"El alumno con el promedio más alto es: {nombreMayor} ({mayorPromedio})");
            Console.WriteLine();
        }

        public void alumnosDesaprobados()
        {
            Console.WriteLine("Alumnos con al menos una nota desaprobada");
            bool algunoDesaprobado = false;

            for (int f = 0; f < 3; f++)
            {
                if (alumnos[f].tieneDesaprobada())
                {
                    Console.WriteLine(alumnos[f].retornarNombre());
                    algunoDesaprobado = true;
                }
            }

            if (!algunoDesaprobado)
            {
                Console.WriteLine("Ningún alumno tiene notas desaprobadas.");
            }
        }

        static void Main(string[] args)
        {
            curso c = new curso();
            c.imprimirPromedios();
            c.promedioMasAlto();
            c.alumnosDesaprobados();

            Console.ReadKey();
        }
    }
}