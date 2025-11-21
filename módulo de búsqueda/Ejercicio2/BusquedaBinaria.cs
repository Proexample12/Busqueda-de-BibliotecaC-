using módulo_de_búsqueda.Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace módulo_de_búsqueda
{
    public class BúsquedaBinaria 
    {
        public static void Ejecutar()
        {
            Console.Clear();

            Console.WriteLine("Ejercicio 2 ejecutado (por ahora vacío).");
            List<Autor> autores = new List<Autor>()
        {
            new Autor("Antoine de Saint-Exupéry"),
            new Autor("Carlos Ruiz Zafón"),
            new Autor("Ernest Hemingway"),
            new Autor("Fiódor Dostoyevski"),
            new Autor("Gabriel García Márquez"),
            new Autor("George Orwell"),
            new Autor("Homer"), // o Homero
            new Autor("Jane Austen"),
            new Autor("J.K. Rowling"),
            new Autor("J.R.R. Tolkien"),
            new Autor("Patrick Rothfuss"),
            new Autor("Paulo Coelho"),
            new Autor("Ray Bradbury"),
            new Autor("Stephen King")
        };

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==== MÓDULO DE BÚSQUEDA BINARIA DE AUTORES ====");
                Console.WriteLine("1. Buscar autor");
                Console.WriteLine("2. Mostrar lista ordenada");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                    opcion = 0;

                switch (opcion)
                {
                    case 1:
                        BuscarAutor(autores);
                        break;

                    case 2:
                        MostrarAutores(autores);
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcion != 3);
        }
        public static int BusquedaBinaria(List<Autor> lista, string nombre)
        {
            int inicio = 0;
            int fin = lista.Count - 1;

            nombre = nombre.ToLower();  // Normalizar texto

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(lista[medio].Nombre.ToLower(), nombre);

                if (comparacion == 0)
                    return medio;     // Encontrado

                if (comparacion < 0)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }

            return -1; // No encontrado
        }

        public static void BuscarAutor(List<Autor> autores)
        {
            Console.Write("\nIngrese el nombre del autor a buscar: ");
            string nombre = Console.ReadLine();

            int indice = BusquedaBinaria(autores, nombre);

            if (indice >= 0)
            {
                Console.WriteLine($"\nAutor encontrado: {autores[indice]}");
            }
            else
            {
                Console.WriteLine("\nNo se encontró el autor.");
            }
        }

        public static void MostrarAutores(List<Autor> autores)
        {
            Console.WriteLine("\nLISTA ORDENADA DE AUTORES:");
            foreach (var autor in autores)
            {
                Console.WriteLine(autor);
            }
        }
    }
}
