using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
    Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
    herencia: Material, Herramienta y Martillo.
    • La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
    Plástico).
    • La clase Herramienta (que hereda de Material) debe añadir el atributo
    FuncionPrincipal.
    • La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
    Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
    correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
    acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
    (ejemplo: "Constructor de la clase Material ejecutado").
    En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
    parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
    en cadena de los constructores (desde la raíz hasta la clase derivada). */

namespace Punto4
{
    class material
    {
        protected string tipoMaterial;

        public material(string tipoMaterial)
        {
            this.tipoMaterial = tipoMaterial;
            Console.WriteLine("Constructor de la clase Material ejecutado");
        }
    }

    class herramienta : material
    {
        protected string funcionPrincipal;

        public herramienta(string tipoMaterial, string funcionPrincipal) : base(tipoMaterial)
        {
            this.funcionPrincipal = funcionPrincipal;
            Console.WriteLine("Constructor de la clase Herramienta ejecutado");
        }
    }

    class martillo : herramienta
    {
        private int pesoGramos;

        public martillo(string tipoMaterial, string funcionPrincipal, int pesoGramos) : base(tipoMaterial, funcionPrincipal)
        {
            this.pesoGramos = pesoGramos;
            Console.WriteLine("Constructor de la clase Martillo ejecutado");
        }

        public void imprimir()
        {
            Console.WriteLine("\nDatos Martiullo");
            Console.WriteLine($"Material base: {tipoMaterial}");
            Console.WriteLine($"Función: {funcionPrincipal}");
            Console.WriteLine($"Peso: {pesoGramos} gramos");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            martillo miMartillo = new martillo("Acero con mango de Madera", "Clavar y romper superficies", 500);

            miMartillo.imprimir();

            Console.ReadKey();
        }
    }
}