using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Punto5
    {
        static void Main(string[] args)
        {
            //5.Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (la circunferencia
            //se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            double radio;
            string linea;

            Console.WriteLine("Se mostrara la circunferencia y el area del circulo");

            Console.Write("Ingresar el radio de un circulo: ");
            linea = Console.ReadLine();
            radio = double.Parse(linea);

            double circunferencia = (radio * 2) * Math.PI;
            Console.WriteLine("Circunferencia es: " + circunferencia);

            double area = Math.PI * (radio * radio);
            Console.WriteLine("El area es: " + area);

            Console.ReadKey();
        }
    }
}
