using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  5-
    Un taller mecánico automatizado administra la recepción y egreso de automóviles
    que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
            o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
            reparación de un vehículo para agregarlo a la lista mediante .Add().
            o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
            recorriendo la lista, informar si el vehículo está en el taller y mostrar
            su costo asociado.
            o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
            vehículo en la lista y, si existe, removerlo de la colección mediante
            .Remove() confirmando la entrega del automóvil.

            o CalcularRecaudacionPendiente(): Listar los vehículos
            actualmente en reparación, la cantidad total de unidades alojadas en
            el taller mediante la propiedad .Count y la suma total acumulada por
            cobrar.
*/

namespace Punto5
{
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            get
            {
                return patente;
            }

            set
            {
                patente = value;
            }
        }

        public double CostoReparacion
        {
            get
            {
                return costoReparacion;
            }

            set
            {
                costoReparacion = value;
            }
        }

        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
    }
    class GestionTaller
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            Console.Write("Patente: ");
            string pat = Console.ReadLine();

            Console.Write("Costo de reparacion: ");
            double costo = double.Parse(Console.ReadLine());

            Vehiculo nuevo = new Vehiculo(pat, costo);
            vehiculos.Add(nuevo);

            Console.WriteLine("Vehiculo ingresado al taller.");
        }

        public void BuscarVehiculo()
        {
            Console.Write("Ingrese la patente a buscar: ");
            string pat = Console.ReadLine();

            bool encontrado = false;
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Patente == pat)
                {
                    Console.WriteLine($"Vehiculo encontrado. Costo de reparacion: ${v.CostoReparacion}");
                    encontrado = true;
                }

                else if (encontrado == false)
                {
                    Console.WriteLine("El vehiculo no esta en el taller.");
                }
            }
        }


        public void EntregarVehiculo()
        {
            Console.Write("Ingrese la patente a entregar: ");
            string pat = Console.ReadLine();

            Vehiculo encontrado = null;
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Patente == pat)
                {
                    encontrado = v;
                }
            }

            if (encontrado != null)
            {
                vehiculos.Remove(encontrado);
                Console.WriteLine($"Vehiculo {pat} entregado.");
            }
            else
            {
                Console.WriteLine("Vehiculo no encontrado.");
            }
        }

        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine("Vehiculos en reparacion");
            double totalPendiente = 0;

            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine($"{v.Patente} - Costo: ${v.CostoReparacion}");
                totalPendiente += v.CostoReparacion;
            }

            Console.WriteLine($"Cantidad de vehiculos en taller: {vehiculos.Count}");
            Console.WriteLine($"Recaudacion pendiente total: ${totalPendiente}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestionTaller taller = new GestionTaller();

            taller.IngresarVehiculo();
            taller.IngresarVehiculo();
            taller.BuscarVehiculo();
            taller.CalcularRecaudacionPendiente();
            taller.EntregarVehiculo();
            taller.CalcularRecaudacionPendiente();

            Console.ReadLine();
        }
    }
}