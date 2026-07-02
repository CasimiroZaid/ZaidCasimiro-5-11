using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1. Confeccionar una clase que represente un empleado. Definir como atributos su
    nombre y su sueldo. En el constructor cargar los atributos y luego en otro
    método imprimir sus datos y por último uno que imprima un mensaje si debe
    pagar impuestos (si el sueldo supera a 3000)*/

namespace Punto1
{
    class empleado
    {
        private string nombre;
        private double sueldo;

        public empleado()
        {
            Console.Write("Nombre empleado: ");
            nombre = Console.ReadLine();
        }
            Console.Write($"Sueldo de {nombre}: ");
            sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void imprimir()
        {       
            Console.WriteLine($"Datos de {nombre}");
            Console.WriteLine();

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Sueldo: {sueldo}");
            Console.WriteLine();
        }

        public void impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine($"Su sueldo es de {sueldo}, supera los 3000. Paga impuestos");
            }
        }

        static void Main(string[] args)
        {
            empleado e = new empleado();

            e.imprimir();
            e.impuestos();

            Console.ReadKey();
        }
    }
}
