using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2-
        Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
        drones de entrega en vuelo de regreso a la base.
             Crear la clase Dron que contenga los atributos privados: codigo (string) y
            nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
            Su constructor debe recibir cod y bat.
             Crear la clase CentroControl que administre una lista de objetos
            List&lt;Dron&gt;.
             Métodos en CentroControl:
                1. Un constructor que cargue por teclado una lista inicial de 4 drones
                ingresando sus códigos y baterías.
                2. ListarFlota(): Mostrar la lista de drones en pantalla.
                3. RemoverDronesBajos(): Recorrer la lista y remover por
                completo de la flota a todos aquellos drones cuyo nivel de batería
                sea menor o igual al 15% (ya que requieren mantenimiento
                automático urgente).
                4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
                cantidad de drones operativos utilizando la propiedad .Count.
*/

namespace Punto2
{
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int NivelBateria
        {
            get
            {
                return nivelBateria;
            }
            set
            {
                nivelBateria = value;
            }
        }

        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
        class CentroControl
        {
            private List<Dron> flota = new List<Dron>();

            public CentroControl()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Dron N° {i + 1}");

                    Console.Write("Codigo: ");
                    string cod = Console.ReadLine();

                    Console.Write("Nivel de batería (0-100): ");
                    int bat = int.Parse(Console.ReadLine());

                    Dron nuevo = new Dron(cod, bat);
                    flota.Add(nuevo);
                }
            }

            public void ListarFlota()
            {
                Console.WriteLine("Flota actual");
                foreach (Dron d in flota)
                {
                    Console.WriteLine($"Codigo: {d.Codigo} - Bateria: {d.NivelBateria}%");
                }
            }

            public void RemoverDronesBajos()
            {
                for (int i = flota.Count - 1; i >= 0; i--)
                {
                    if (flota[i].NivelBateria <= 15)
                    {
                        Console.WriteLine($"Removiendo dron {flota[i].Codigo} por bateria baja.");
                        flota.RemoveAt(i);
                    }
                }
            }

            public void MostrarDronesRestantes()
            {
                Console.WriteLine("Drones operativos");
                foreach (Dron d in flota)
                {
                    Console.WriteLine($"Codigo: {d.Codigo} - Bateria: {d.NivelBateria}%");
                }
                Console.WriteLine($"Cantidad de drones operativos: {flota.Count}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                CentroControl centro = new CentroControl();
                centro.ListarFlota();
                centro.RemoverDronesBajos();
                centro.MostrarDronesRestantes();

                Console.ReadLine();
            }
        }
    }
}