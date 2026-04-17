using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
    realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
    vectores paralelos, ordenar los datos de mayor a menor según las ventas,
    imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
    el que menos vendió de los 5 empleados.
*/

namespace Punto2
{
    class empresa
    {
        private string[] nombreVendedor;
        private int[] ventasMes;

        public void cargarNombres()
        {
            nombreVendedor = new string[5];

            Console.WriteLine("Cargar los nombres de los vendedores");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre del vendedor " + (i + 1) + ": ");
                nombreVendedor[i] = Console.ReadLine();
            }
        }
        public void cargarTotalVentas()
        {
            ventasMes = new int[5];

            Console.WriteLine();
            Console.WriteLine("Cargar total de ventas realizadas por cada uno en un mes");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ventas de " + nombreVendedor[i] + ": ");
                ventasMes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ordenamiento()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5 - 1 - k; j++)
                {
                    if (ventasMes[j] < ventasMes[j + 1])
                    {
                        int aux = ventasMes[j];
                        ventasMes[j] = ventasMes[j + 1];
                        ventasMes[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empleados, ordenada de mayor a menor segun las ventas");

            for (int i = 0; i < 5; i++)
            {

            }
        }

        static void Main(string[] args)
        { 
            empresa n = new empresa();

            n.cargarNombres();
            n.cargarTotalVentas();
            n.ordenamiento();

            Console.ReadKey();
        }
    }
}
