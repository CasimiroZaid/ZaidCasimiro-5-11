using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            de $300. Además el programa deberá informar el importe que gasta la empresa
            en sueldos al personal.*/

            int empleados, entre = 0, alto = 0;
            double importe = 0, sueldo = 0;

            Console.Write("Ingresar numero de empleados: ");
            empleados = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de empleados: " + empleados);

            for (int i = 0; i < empleados; i++)
            {
                Console.Write("Ingresar sueldo (" + (i + 1) + "): ");
                sueldo = double.Parse(Console.ReadLine());

                importe = importe + sueldo;

                if (sueldo >= 100 && sueldo <= 500)
                {
                    if (sueldo <= 300)
                    {
                        Console.WriteLine("Sueldo entre $100 y $300");
                        entre++;
                    } 
                    else
                    {
                        Console.WriteLine("Sueldo mayor a $300");
                        alto++;
                    }
                }
                else
                {
                    Console.WriteLine("Sueldo fuera del rango de $100 y entre $300");
                }
            }

            Console.WriteLine("Total de sueldos entre $100 y $300: " + entre);
            Console.WriteLine("Total de sueldos mayores a $300: " + alto);
            Console.WriteLine("Importe de la empresa: " + importe);
            Console.ReadKey();
        }
    }
}
