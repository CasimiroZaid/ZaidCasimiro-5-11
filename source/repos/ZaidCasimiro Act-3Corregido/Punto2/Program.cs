/* 2. Se ingresan tres valores por teclado, si todos son iguales se imprime 
   la suma del primero con el segundo y a este resultado se lo multiplica por el tercero. */

using System;

class Punto2
{
    static void Main()
    {
        int num1, num2, num3, suma, resultado;

        Console.Write("Valor 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Valor 2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Valor 3: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            suma = num1 + num2;
            Console.WriteLine("Suma del primero y segundo: " + suma);

            resultado = suma * num3;
            Console.WriteLine("Resultado final: " + resultado);
        }

        Console.ReadKey();
    }
}