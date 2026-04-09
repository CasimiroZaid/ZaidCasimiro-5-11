using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).
*/

namespace Punto3
{
    class Empleado
    {
        private string nombre;
        private float sueldo;

        public void CargarDatos()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Datos del empleado");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado tiene que pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado no paga impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();

            empleado1.CargarDatos();
            empleado1.ImprimirDatos();
            empleado1.Impuestos();

            Console.ReadKey();
        }
    }
}