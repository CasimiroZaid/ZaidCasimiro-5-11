using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            informe:
                a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
                que:
                Estado de la cuenta:
                    ○ “Acreedor” si el saldo es >0.
                    ○ “Deudor” si el saldo es <0.
                    ○ “Nulo” si el saldo es =0.
                b) La suma total de los saldos acreedores. */

            int ncuenta;
            double saldo, total = 0;
            string estado;

            while (true)
            {
                Console.Write("Ingresar numero de cuenta: ");
                ncuenta = int.Parse(Console.ReadLine());

                if (ncuenta < 0)
                {
                    break;
                }

                Console.Write("Ingresar saldo de cuenta: ");
                saldo = double.Parse(Console.ReadLine());

                if (saldo > 0)
                {
                    estado = "Acreedor";
                    total += saldo;
                }
                else if (saldo < 0)
                {
                    estado = "Deudor";
                }
                else
                {
                    estado = "Nulo";
                }

                Console.WriteLine("Numero de cuenta: " + ncuenta + " / Saldo: " + saldo + " / Estado: " + estado);
            }

            Console.WriteLine("Finalizo la carga de datos");
            Console.WriteLine("Total de saldos acreedores: " + total);

            Console.ReadKey();
        }
    }
}
