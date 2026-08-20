using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1-
        En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
        llegada.
             Crear la clase Documento que contenga como atributos privados:
            nombreArchivo (string) y cantidadPaginas (int). Definir sus
            propiedades de solo lectura y un constructor que reciba los parámetros nom
            y pag.
             Crear la clase ServidorImpresion que administre una lista dinámica de
            documentos (List&lt;Documento&gt;).
             Métodos en ServidorImpresion:
                1. AgregarDocumento(): Solicitar por teclado los datos de un
                documento y agregarlo al final de la lista utilizando .Add().
                2. ImprimirSiguiente(): Si la lista no está vacía, simular la
                impresión del primer documento de la lista (mostrar sus datos en
                consola) y removerlo de la colección mediante .RemoveAt(0). Si está
                vacía, advertir que no hay trabajos pendientes.
                3. MostrarColaPendiente(): Listar todos los documentos que
                están esperando ser impresos y la cantidad total de páginas
                acumuladas en la cola de espera utilizando .Count.
*/

namespace Punto1
{
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            get
            {
                return nombreArchivo;
            }
        }

        public int CantidadPaginas
        {
            get
            {
                return cantidadPaginas;
            }
        }

        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }
    class ServidorImpresion
    {
        private List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            Console.Write("Ingrese el nombre del archivo: ");
            string nom = Console.ReadLine();

            Console.Write("Ingrese la cantidad de páginas: ");
            int pag = int.Parse(Console.ReadLine());

            Documento nuevo = new Documento(nom, pag);
            documentos.Add(nuevo);

            Console.WriteLine("Documento agregado a la cola.");
        }

        public void ImprimirSiguiente()
        {
            if (documentos.Count > 0)
            {
                Documento actual = documentos[0];
                Console.WriteLine($"Imprimiendo: {actual.NombreArchivo} ({actual.CantidadPaginas} paginas)");
                documentos.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay trabajos pendientes.");
            }
        }

        public void MostrarColaPendiente()
        {
            Console.WriteLine("Cola pendiente");
            int totalPaginas = 0;

            foreach (Documento doc in documentos)
            {
                Console.WriteLine($"{doc.NombreArchivo} - {doc.CantidadPaginas} paginas");
                totalPaginas += doc.CantidadPaginas;
            }

            Console.WriteLine($"Documentos en espera: {documentos.Count}");
            Console.WriteLine($"Total de paginas acumuladas: {totalPaginas}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServidorImpresion servidor = new ServidorImpresion();

            servidor.AgregarDocumento();
            servidor.MostrarColaPendiente();
            servidor.ImprimirSiguiente();
            servidor.MostrarColaPendiente();

            Console.ReadLine();
        }
    }
}