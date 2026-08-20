using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  6-
        Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
        para organizar la consulta de ejemplares por parte de los lectores.
             Crear la clase Libro que contenga como atributos privados: titulo
            (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
            un constructor que reciba tit y anio.
             Crear la clase BibliotecaCentral que administre una lista de objetos
            List.
             Métodos en BibliotecaCentral:
                1. CargarCatalogo(): Solicitar por teclado títulos y años de
                publicación para agregar libros a la lista mediante .Add(). La carga
                finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
                2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
                junto a la cantidad total de obras registradas mediante la propiedad
                .Count.
                3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
                imprimir en consola únicamente aquellos libros cuyo año de
                publicación sea menor a dicho valor.
                4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
                los métodos de búsqueda y remoción de listas, eliminarlo de la
                colección si se encuentra presente.
*/

namespace Punto6
{
    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        public int AnioPublicacion
        {
            get
            {
                return anioPublicacion;
            }
        }

        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }
    class BibliotecaCentral
    {
        private List<Libro> catalogo = new List<Libro>();

        public void CargarCatalogo()
        {
            string titulo;
            do
            {
                Console.Write("Titulo del libro (o FIN para terminar): ");
                titulo = Console.ReadLine();

                if (titulo != "FIN")
                {
                    Console.Write("Anio de publicacion: ");
                    int anio = int.Parse(Console.ReadLine());

                    Libro nuevo = new Libro(titulo, anio);
                    catalogo.Add(nuevo);
                }

            } while (titulo != "FIN");
        }

        public void ListarCatalogo()
        {
            Console.WriteLine("Catalogo de la biblioteca");
            foreach (Libro l in catalogo)
            {
                Console.WriteLine($"{l.Titulo} ({l.AnioPublicacion})");
            }
            Console.WriteLine($"Total de obras registradas: {catalogo.Count}");
        }

        public void FiltrarPorAnio()
        {
            Console.Write("Ingrese un anio: ");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine($"Libros publicados antes de {anio}");
            foreach (Libro l in catalogo)
            {
                if (l.AnioPublicacion < anio)
                {
                    Console.WriteLine($"{l.Titulo} ({l.AnioPublicacion})");
                }
            }
        }

        public void RemoverLibro()
        {
            Console.Write("Ingrese el titulo del libro a eliminar: ");
            string titulo = Console.ReadLine();

            Libro encontrado = null;
            foreach (Libro l in catalogo)
            {
                if (l.Titulo == titulo)
                {
                    encontrado = l;
                }
            }

            if (encontrado != null)
            {
                catalogo.Remove(encontrado);
                Console.WriteLine($"Libro: {titulo} eliminado del catálogo.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado en el catalogo.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecaCentral biblioteca = new BibliotecaCentral();

            biblioteca.CargarCatalogo();
            biblioteca.ListarCatalogo();
            biblioteca.FiltrarPorAnio();
            biblioteca.RemoverLibro();
            biblioteca.ListarCatalogo();

            Console.ReadLine();
        }
    }
}