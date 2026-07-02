using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Sistema de Logística: Envíos por Sucursal
    Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
    cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
            1. Cargar los nombres de las sucursales and, para cada una, preguntar cuántos
            paquetes se enviaron hoy para definir el tamaño de su fila.
            2. Cargar el peso de cada paquete.
            3. Imprimir el peso de todos los paquetes organizados por sucursal.
            4. Calcular e informar el peso total despachado por cada sucursal.
            5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
            pertenece.
*/

namespace Punto1
{
    class empresa
    {
        private string[] sucursales;
        private double[][] paquetes;
        private double pesoTotal = 0;
        private double mayor;
        private int mayors = 0;

        public void cargarDatos()
        {
            sucursales = new string[3];
            paquetes = new double[sucursales.Length][];

            int cantPaquetes = 0;

            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.Write($"Ingresar nombre de la sucursal {i + 1}: ");
                sucursales[i] = Console.ReadLine();
                Console.WriteLine();

                Console.Write($"Cuantos paquetes envio la sucursal {sucursales[i]}: ");
                cantPaquetes = int.Parse(Console.ReadLine());
                paquetes[i] = new double[cantPaquetes];
                Console.WriteLine();

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.Write($"Peso del paquete {j + 1}: ");
                    paquetes[i][j] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("Peso de paquetes por sucursal.");

            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine($"\nSucursal: {sucursales[i]}");

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.WriteLine($"Paquete {j + 1}: {paquetes[i][j]}Kg");
                }
            }
        }

        public void pesoTotalDespachado()
        {
            for (int i = 0; i < sucursales.Length; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    pesoTotal += paquetes[i][j];
                }

                Console.WriteLine($"\nPeso total de {sucursales[i]}: {pesoTotal}Kg");

                pesoTotal = 0;
            }
        }

        public void masPesado()
        {
            mayor = -1;

            for (int i = 0; i < sucursales.Length; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    if (paquetes[i][j] > mayor)
                    {
                        mayors = i;
                        mayor = paquetes[i][j];
                    }
                }
            }

            Console.WriteLine($"\nEl paquete mas pesado de la empresa: {mayor}Kg de la sucursal: {sucursales[mayors]}");
        }

        static void Main(string[] args)
        {
            empresa empresa1 = new empresa();

            empresa1.cargarDatos();
            empresa1.imprimir();
            empresa1.pesoTotalDespachado();
            empresa1.masPesado();

            Console.ReadKey();
        }
    }
}