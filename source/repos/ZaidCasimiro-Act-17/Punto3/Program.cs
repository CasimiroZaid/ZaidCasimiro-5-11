using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Fábrica de Computadoras (Herencia y Constructores con base)
    Crear una clase base llamada Computadora que contenga los atributos Marca y
    MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
    Luego, definir dos clases derivadas de la clase base:
    • Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
    • Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
    Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola. */

namespace Punto3
{
    class computadora
    {
        protected string marca;
        protected int memoriaRam;

        public computadora(string marca, int memoriaRam)
        {
            this.marca = marca;
            this.memoriaRam = memoriaRam;
        }
    }

    class notebook : computadora
    {
        private double tamanoPantalla;

        public notebook(string marca, int memoriaRam, double tamanoPantalla) : base(marca, memoriaRam)
        {
            this.tamanoPantalla = tamanoPantalla;
        }

        public void mostrarNotebook()
        {
            Console.WriteLine("Datos de la Notebook");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Memoria RAM: {memoriaRam} GB");
            Console.WriteLine($"Tamaño de Pantalla: {tamanoPantalla} pulgadas\n");
        }
    }

    class escritorio : computadora
    {
        private int potenciaFuente;

        public escritorio(string marca, int memoriaRam, int potenciaFuente) : base(marca, memoriaRam)
        {
            this.potenciaFuente = potenciaFuente;
        }

        public void mostrarEscritorio()
        {
            Console.WriteLine("Datos de la PC de Escritorio");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Memoria RAM: {memoriaRam} GB");
            Console.WriteLine($"Potencia de Fuente: {potenciaFuente} Watts\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            notebook net1 = new notebook("Dell", 16, 15.6);
            escritorio pc1 = new escritorio("ASUS", 32, 750);

            net1.mostrarNotebook();
            pc1.mostrarEscritorio();

            Console.ReadKey();
        }
    }
}