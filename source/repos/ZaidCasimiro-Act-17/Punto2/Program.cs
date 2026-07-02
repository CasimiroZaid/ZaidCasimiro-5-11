using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. Catálogo de Películas (Encapsulación, Validación y Composición)
    Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
    La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
    películas ordenadas de mayor a menor en base a su duración. Además, el método debe
    informar el título de la película con mejor calificación y cuál es la película más corta del
    catálogo.
*/


namespace Punto2
{
    class pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private double calificacion;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public int DuracionMinutos
        {
            set
            {
                if (value > 0)
                {
                    duracionMinutos = value;
                }
            }

            get
            {
                return duracionMinutos;
            }
        }

        public double Calificacion
        {
            set
            {
                if (value >= 1 && value <= 5)
                {
                    calificacion = value;
                }
                else
                {
                    calificacion = 1;
                }
            }

            get
            {
                return calificacion;
            }
        }
    }

    class catalogo
    {
        public pelicula[] peliculas = new pelicula[3];

        public catalogo()
        {
            peliculas[0] = new pelicula();
            peliculas[1] = new pelicula();
            peliculas[2] = new pelicula();
        }

        public void mostrar()
        {
            // Se cambia tempPos int por un aux tipo pelicula para ordenar objetos completos
            pelicula aux;
            int mayorpos = 0;
            int menorpos = 0;

            for (int i = 0; i < peliculas.Length - 1; i++)
            {
                for (int j = 0; j < peliculas.Length - i - 1; j++)
                {
                    // Ordenamos de mayor a menor como pide la consigna
                    if (peliculas[j].DuracionMinutos < peliculas[j + 1].DuracionMinutos)
                    {
                        aux = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Películas ordenadas de mayor a menor por duración:\n");
            for (int i = 0; i < peliculas.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {peliculas[i].Titulo} - {peliculas[i].DuracionMinutos} mins (Calificación: {peliculas[i].Calificacion}/5)");
            }

            // Buscar la mejor calificada
            for (int i = 1; i < peliculas.Length; i++)
            {
                if (peliculas[i].Calificacion > peliculas[mayorpos].Calificacion)
                {
                    mayorpos = i;
                }
            }
            Console.WriteLine($"\nPelícula con mejor calificación: {peliculas[mayorpos].Titulo} ({peliculas[mayorpos].Calificacion}/5)");

            // Buscar la más corta
            for (int i = 1; i < peliculas.Length; i++)
            {
                if (peliculas[i].DuracionMinutos < peliculas[menorpos].DuracionMinutos)
                {
                    menorpos = i;
                }
            }
            Console.WriteLine($"Película más corta: {peliculas[menorpos].Titulo} ({peliculas[menorpos].DuracionMinutos} mins)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            catalogo c1 = new catalogo();
            c1.peliculas[0].Titulo = "Batman";
            c1.peliculas[0].DuracionMinutos = 175;
            c1.peliculas[0].Calificacion = 4.8;

            c1.peliculas[1].Titulo = "Shrek";
            c1.peliculas[1].DuracionMinutos = 90;
            c1.peliculas[1].Calificacion = 5.0;

            c1.peliculas[2].Titulo = "Shrek2";
            c1.peliculas[2].DuracionMinutos = 87;
            c1.peliculas[2].Calificacion = 4;

            c1.mostrar();

            Console.ReadKey();
        }
    }
}