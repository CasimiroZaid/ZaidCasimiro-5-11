using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1. Confeccionar una clase Persona que tenga como atributos el nombre y la
    edad (definir las propiedades para poder acceder a dichos atributos). Definir
    un método para imprimirlos. Plantear una segunda clase Empleado que
    herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
    método para imprimir su sueldo. Definir un objeto de la clase Persona y
    llamar a sus métodos y propiedades. También crear un objeto de la clase
    Empleado y llamar a sus métodos y propiedades.
*/

namespace Punto1
{
    class Persona
    {
        protected string nombre;
        protected int edad;

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

        public int Edad
        {
            set
            {
                edad = value;
            }

            get
            {
                return edad;
            }
        }

        public void imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
        }
    }

    class Empleado : Persona
    {
        protected double sueldo;

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }

            get
            {
                return sueldo;
            }
        }

        public void imprimirSueldo()
        {
            Console.WriteLine($"Sueldo: {sueldo}");
        }
    }

    class main
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Console.WriteLine("Persona");
            persona1.Nombre = "Pablo";
            persona1.Edad = 29;
            persona1.imprimir();

            Empleado empleado1 = new Empleado();
            Console.WriteLine("\nEmpleado");
            empleado1.Nombre = "Marcos";
            empleado1.Edad = 30;
            empleado1.Sueldo = 200;
            empleado1.imprimir();
            empleado1.imprimirSueldo();

            Console.ReadKey();
        }
    }
}

