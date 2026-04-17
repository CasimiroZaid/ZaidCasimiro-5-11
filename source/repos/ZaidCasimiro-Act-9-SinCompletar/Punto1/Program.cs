using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1. Se desea desarrollar un programa que permita registrar los nombres y las
    calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
    nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
    estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
    máxima o mínima.
*/

namespace Punto1
{
    class estudiantes
    {
        private string[] nombre;
        private float[] nota;


        private float menor;
        private float mayor;

        private int repMayor;
        private int repMenor;

        public void cargarNombres()
        {
            nombre = new string[6];

            Console.WriteLine("Resgistrar nombre de los estudiantes");

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Estudiante " + (i + 1) + ": ");
                nombre[i] = Console.ReadLine();
            }
        }

        public void cargarNotas()
        {
            nota = new float[6];

            Console.WriteLine();
            Console.WriteLine("Registrar notas de los estudiantes");

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Nota de " + (nombre[i]) + ": ");
                nota[i] = float.Parse(Console.ReadLine());
            }
        }

        public void notaAlta()
        {
            repMayor = 0;
            mayor = nota[0];
            int paralelo = 0;

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                if (nota[i] > mayor)
                {
                    mayor = nota[i];
                    paralelo = i;

                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (nota[i] == mayor)
                {
                    repMayor++;
                }
            }

            if (repMayor > 1)
            {
                Console.WriteLine("Los alumnos con la nota mas alta de " + mayor + " son: ");

                for (int i = 0; i < 6; i++)
                {
                    if (nota[i] == mayor)
                    {
                        Console.WriteLine(nombre[i]);
                    }
                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante con la nota mas alta es: " + nombre[paralelo] + " con una nota de " + mayor);
            }
        }

        public void notaBaja()
        {
            repMenor = 0;
            menor = nota[0];
            int paralelo = 0;

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                if (nota[i] < menor)
                {
                    menor = nota[i];
                    paralelo = i;

                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (nota[i] == menor)
                {
                    repMenor++;
                }
            }

            if (repMenor > 1)
            {
                Console.WriteLine("Los alumnos con la nota mas baja de " + menor + " son: ");

                for (int i = 0; i < 6; i++)
                {
                    if (nota[i] == menor)
                    {
                        Console.WriteLine(nombre[i]);
                    }
                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante con la nota mas baja es: " + nombre[paralelo] + " con una nota de " + menor);
            }
        }
        static void Main(string[] args)
        {
            estudiantes n = new estudiantes();

            n.cargarNombres();
            n.cargarNotas();
            n.notaAlta();
            n.notaBaja();

            Console.ReadKey();
        }
    }
}