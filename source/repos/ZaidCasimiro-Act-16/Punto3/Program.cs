using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    3. Crear una clase base Vehículo que contenga atributos marca y
    velocidadMaxima.
    Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
    una debe tener un constructor que reciba los valores de los atributos base
    mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    Auto, cilindrada en Moto).
    Crear un objeto de cada clase y mostrar todos sus datos por consola.
*/

namespace Punto3
{
    class Vehiculo
    {
        protected string marca;
        protected double velocidadMaxima;

        public Vehiculo(string marca, double velocidadMaxima)
        {
            this.marca = marca;
            this.velocidadMaxima = velocidadMaxima;
        }

        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }

        public double VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
    }

    class Auto : Vehiculo
    {
        private int cantidadPuertas;

        public Auto(string marca, double velocidadMaxima, int cantidadPuertas) : base(marca, velocidadMaxima)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        public void mostrar()
        {
            Console.WriteLine("Auto");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Velocidad máxima: {velocidadMaxima}");
            Console.WriteLine($"Cantidad de puertas: {cantidadPuertas}\n");
        }
    }

    class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string marca, double velocidadMaxima, int cilindrada) : base(marca, velocidadMaxima)
        {
            this.cilindrada = cilindrada;
        }

        public void mostrar()
        {
            Console.WriteLine("Moto");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Velocidad máxima: {velocidadMaxima}");
            Console.WriteLine($"Cilindrada: {cilindrada}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Toyota", 200, 5);
            Moto moto1 = new Moto("Honda", 180, 200);

            auto1.mostrar();
            moto1.mostrar();

            Console.ReadKey();
        }
    }
}

