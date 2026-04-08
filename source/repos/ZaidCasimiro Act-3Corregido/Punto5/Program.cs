/* 5. Escribir un programa que pida ingresar la coordenada de un punto (x, y).
   Imprimir en qué cuadrante se ubica. */

using System;

class Punto5
{
    static void Main()
    {
        int x, y;

        Console.Write("Ingrese coordenada X: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese cordenada Y: ");
        y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("1º Cuadrante");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2º Cuadrante");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3º Cuadrante");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("4º Cuadrante");
        }

        Console.ReadKey();        
    }
}