using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1. Personal de un Gimnasio (Herencia Simple y Propiedades)
    Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
    método para imprimir estos datos básicos.
    Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    para imprimir todos los datos del profesor (incluyendo los heredados).
    En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.
*/

namespace Punto1
{
    class PersonaGimnasio
    {
        private string nombre;
        private int dni;

        public string Nombre
        {
            set
            {

                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public void mostrar()
        {
            Console.WriteLine("Datos Básicos:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"DNI: {dni}");
        }
    }

    class profesor : PersonaGimnasio
    {
        private string especialidad;

        public string Especialidad
        {
            set { especialidad = value; }
            get { return especialidad; }
        }

        public void imprimir()
        {
            Console.WriteLine("\n--- DATOS DEL PROFESOR ---");
            base.mostrar();
            Console.WriteLine($"Especialidad: {especialidad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PersonaGimnasio persona1 = new PersonaGimnasio();
            persona1.Nombre = "Pablo";
            persona1.Dni = 30123321;
            persona1.mostrar();

            profesor profesor1 = new profesor();
            profesor1.Nombre = "Leonel";
            profesor1.Dni = 35678798;
            profesor1.Especialidad = "Musculacion";
            profesor1.imprimir();

            Console.ReadKey();
        }
    }
}