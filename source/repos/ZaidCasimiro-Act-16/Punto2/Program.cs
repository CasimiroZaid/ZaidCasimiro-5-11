using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
    2. Plantear una clase Producto y otra clase Inventario.
    La clase Producto debe tener como atributos privados el nombre, precio y
    stock. Definir propiedades para acceder a estos atributos, asegurando que el
    stock no pueda ser negativo y el precio sea mayor a cero.
    La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
    método para mostrar todos los productos ordenados de menor a mayor en
    base al precio, además, mostrar el producto más caro y más barato del
    inventario.
*/

namespace Punto2
{
    class Producto
    {
        private string nombre;
        private double precio;
        private int stock;

        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }

        public double Precio
        {
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }

            get
            {
                return precio;
            }
        }

        public int Stock
        {
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }

            get
            {
                return stock;
            }
        }
    }
    class inventario
    {
        private Producto producto1, producto2, producto3;

        public inventario()
        {
            producto1 = new Producto();
            producto1.Nombre = "Computadora";
            producto1.Precio = 1000;
            producto1.Stock = 10;

            producto2 = new Producto();
            producto2.Nombre = "Ventilador";
            producto2.Precio = 400;
            producto2.Stock = 23;

            producto3 = new Producto();
            producto3.Nombre = "Celular";
            producto3.Precio = 800;
            producto3.Stock = 17;
        }

        public void ordenamiento()
        {
            Producto[] productos = { producto1, producto2, producto3 };

            Producto aux;

            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 0; j < productos.Length - 1 - i; j++)
                {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        aux = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Productos ordenados de menor a mayor por precio\n");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}");
                Console.WriteLine($"Precio: {productos[i].Precio}");
                Console.WriteLine($"Stock: {productos[i].Stock}\n");
            }

            Console.WriteLine($"Producto más barato: {productos[0].Nombre} (${productos[0].Precio})");
            Console.WriteLine($"Producto más caro: {productos[productos.Length - 1].Nombre} (${productos[productos.Length - 1].Precio})");
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            inventario inventario1 = new inventario();
            inventario1.ordenamiento();

            Console.ReadKey();
        }
    }
}

