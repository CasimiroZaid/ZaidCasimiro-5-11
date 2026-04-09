using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
*/

namespace Punto1
{
    class Punto
    {
        private int x;
        private int y;

        public void cargarDatos()
        {
            Console.Write("coordenada X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("coordenada Y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void cuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primer Cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Cuadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tercer Cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Cuarto Cuadrante");
            }
            else
            {
                Console.WriteLine("Esta en cero");
            }
        }
   
        static void Main(string[] args)
        {
            Punto n = new Punto();

            n.cargarDatos();
            n.cuadrante();

            Console.ReadKey();
        }
    }
}