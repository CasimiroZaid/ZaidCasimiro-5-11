/* 3. Se ingresan por teclado tres números, si todos los valores ingresados 
   son menores a 10, imprimir "Todos los números son menores a diez" */

using System;

class Punto3
{
    static void Main()
    {

        int num1, num2, num3;

        Console.Write("Numero 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Nmero 2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Numero 3: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 < 10 && num2 < 10 && num3 < 10)
        {
            Console.WriteLine("Todos los números son menores a diez");
        }

        Console.ReadKey();
    }
}