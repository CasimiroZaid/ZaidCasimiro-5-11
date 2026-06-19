using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
    dato las temperaturas medias mensuales de dichos paises.
    Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    mensuales.
    Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    memoria.
        a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
        b. Imprimir los nombres de los paises y las temperaturas medias mensuales de las
        mismas.
        c. Calcular la temperatura media trimestral de cada país.
        d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
        e. Imprimir el nombre del país con la temperatura media trimestral mayor.
*/

namespace Punto1
{
    class clima
    {
        private string[] paises;
        private double[][] temperaturas;
        private double[] mediaTrimestral;

        public void CargarDatos()
        {
            paises = new string[4];
            temperaturas = new double[4][];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del país " + (i + 1) + ": ");
                paises[i] = Console.ReadLine();

                temperaturas[i] = new double[3];

                for (int j = 0; j < temperaturas[i].Length; j++)
                {
                    Console.Write("Temperatura del mes " + (j + 1) + ": ");
                    temperaturas[i][j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Temperaturas Medias Mensuales");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Pais: " + paises[i]);

                for (int j = 0; j < temperaturas[i].Length; j++)
                {
                    Console.WriteLine("Temperatura del mes " + (j + 1) + ": " + temperaturas[i][j]);
                }
                Console.WriteLine();
            }
        }

        public void tempTrimestralMedia()
        {
            mediaTrimestral = new double[4];

            double suma = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                for (int j = 0; j < temperaturas[i].Length; j++)
                {
                    suma += temperaturas[i][j];
                }
                mediaTrimestral[i] = suma / 3;

                suma = 0;
            }
        }

        public void imprimirMediasTrimestre()
        {
            Console.WriteLine("Temperaturas Medias Trimestrales");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("Pais: " + paises[i]);
                Console.WriteLine("Temperatura media trimestral: " + mediaTrimestral[i]);
                Console.WriteLine();
            }
        }

        public void mayorMediaTrimestral()
        {
            double mayor = mediaTrimestral[0];

            int posMayor = 0;

            for (int i = 1; i < mediaTrimestral.Length; i++)
            {
                if (mediaTrimestral[i] > mayor)
                {
                    mayor = mediaTrimestral[i];
                    posMayor = i;
                }
            }

            Console.WriteLine("Temperatura media trimestral mayor es de " + mayor + " de " + paises[posMayor]);
        }

        static void Main(string[] args)
        {
            clima n = new clima();

            n.CargarDatos();
            n.imprimir();
            n.tempTrimestralMedia();
            n.imprimirMediasTrimestre();
            n.mayorMediaTrimestral();

            Console.ReadKey();
        }
    }
}
