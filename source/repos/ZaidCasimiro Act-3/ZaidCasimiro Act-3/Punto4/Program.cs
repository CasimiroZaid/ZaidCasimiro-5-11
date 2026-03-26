/* 4. Se ingresan por teclado tres números, si al menos uno de los valores 
   ingresados es menor a 10, imprimir "Alguno de los números es menor a diez". */

using System;

class Punto4
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("N1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("N2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("N3: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 < 10 || num2 < 10 || num3 < 10)
        {
            Console.WriteLine("Alguno de los números es menor a diez");

        }
    }
}