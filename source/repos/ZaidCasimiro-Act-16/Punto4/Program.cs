using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    4. Armar tres clases: Animal, Mamífero y Perro.
    La clase Animal debe tener un atributo especie.
    La clase Mamífero, que hereda de Animal, debe tener un atributo tipoAlimentacion.
    La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    Cada clase debe tener un constructor que reciba los datos correspondientes
    y los imprima indicando a qué clase pertenecen. Los datos deben ser asignados previamente.
    Crear un objeto de la clase Perro y verificar la ejecución en cadena de los constructores.
*/

namespace Punto4
{
    class Animal
    {
        protected string especie;

        public Animal(string especie)
        {
            this.especie = especie;
            Console.WriteLine("Se ejecutó el constructor de la clase [Animal]");
        }
    }

    class Mamifero : Animal
    {
        protected string tipoAlimentacion;

        public Mamifero(string especie, string tipoAlimentacion) : base(especie)
        {
            this.tipoAlimentacion = tipoAlimentacion;
            Console.WriteLine("Se ejecutó el constructor de la clase [Mamífero]");
        }
    }

    class Perro : Mamifero
    {
        private string nombre;

        public Perro(string especie, string tipoAlimentacion, string nombre) : base(especie, tipoAlimentacion)
        {
            this.nombre = nombre;
            Console.WriteLine("Se ejecutó el constructor de la clase [Perro]");
        }

        public void mostrarDatos()
        {
            Console.WriteLine("\nDATOS DEL PERRO");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Especie: {especie}");
            Console.WriteLine($"Alimentación: {tipoAlimentacion}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro miPerro = new Perro("Canino", "Carnívoro", "Pochi");

            miPerro.mostrarDatos();

            Console.ReadKey();
        }
    }
}