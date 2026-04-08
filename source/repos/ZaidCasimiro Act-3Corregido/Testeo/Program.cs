/* 1. Realizar un programa que pida cargar una fecha cualquiera, 
   luego verificar si dicha fecha corresponde a Navidad. */

using System;

class Punto1
{
    static void Main()
    {
        Console.WriteLine("Ingrese una fecha (dd/mm/aaaa):");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
            
        if (fecha.Day == 25 && fecha.Month == 12)
        {
            Console.WriteLine("La fecha corresponde a Navidad.");
        }
        else
        {
            Console.WriteLine("No es Navidad.");
        }

        Console.ReadKey();
    }
}