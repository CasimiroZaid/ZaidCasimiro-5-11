using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
    un videojuego. El programa debe:
         Mostrar la puntuación más alta y la más baja.
         Calcular el promedio de puntuación.
         Contar cuántas veces superó los 500 puntos.
*/

namespace Punto3
{
    class puntuacion
    {
        private float[] puntuaciones;

        public void ingresarPuntuacion()
        {
            puntuaciones = new float[6];

            for (int i = 0; i < puntuaciones.Length; i++)
            {
                Console.Write("Ingresar puntiacion de la " + (i+1) + " partida: ");
                puntuaciones[i] = float.Parse(Console.ReadLine()); 
                Console.WriteLine();
            }
        }

        public void puntuacionAlta()
        {
            float puntuacionAlta = puntuaciones[0];

            for (int i = 0; i < puntuaciones.Length; i++)
            {
                if (puntuaciones[i] > puntuacionAlta)
                {
                    puntuacionAlta = puntuaciones[i];
                }
            }

            Console.WriteLine("La puntuacion mas alta es: " + puntuacionAlta);
        }

        public void puntuacionBaja()
        {
            float puntuacionBaja = puntuaciones[0];

            for (int i = 0; i < puntuaciones.Length; i++)
            {
                if (puntuaciones[i] < puntuacionBaja)
                {
                    puntuacionBaja = puntuaciones[i];
                }
            }

            Console.WriteLine("La puntuacion mas baja es: " + puntuacionBaja);
        }

        public void puntuacionPromedio()
        {
            float puntuacionProm = 0;

            for (int i = 0; i < puntuaciones.Length; i++)
            {
               puntuacionProm += puntuaciones[i];
            }

            puntuacionProm /= puntuaciones.Length;

            Console.WriteLine("La puntuacion promedio es: " + puntuacionProm);
        }

        public void puntuacion500()
        {
            float puntuacion500 = 0;

            for (int i = 0; i < puntuaciones.Length; i++)
            {
                if (puntuaciones[i] > 500)
                {
                    puntuacion500++;
                }
            }

            Console.WriteLine("La puntuacion supero los 500 " + puntuacion500 + " veces.");
        }

        static void Main(string[] args)
        {
            puntuacion n = new puntuacion();

            n.ingresarPuntuacion();
            n.puntuacionAlta();
            n.puntuacionBaja();
            n.puntuacionPromedio();
            n.puntuacion500();

            Console.ReadKey();
        }
    }
}
