using módulo_de_búsqueda.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace módulo_de_búsqueda
{
    public class BusquedaLineal
    {
        public static void Ejecutar()
        {
            Console.Clear();

            Console.WriteLine("Ejercicio 1 ejecutado .");
            // Lista de libros precargada
            List<Libro> libros = new List<Libro>()
        {
            new Libro("Cien años de soledad", "Gabriel García Márquez"),
            new Libro("El Principito", "Antoine de Saint-Exupéry"),
            new Libro("Don Quijote", "Miguel de Cervantes"),
            new Libro("La Odisea", "Homero"),
            new Libro("Harry Potter", "J.K. Rowling")
        };

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("==== MÓDULO DE BÚSQUEDA DE LIBROS ====");
                Console.WriteLine("1. Buscar libro por título");
                Console.WriteLine("2. Mostrar todos los libros");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                    opcion = 0;

                switch (opcion)
                {
                    case 1:
                        BuscarLibro(libros);
                        break;

                    case 2:
                        MostrarLibros(libros);
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
        public static Libro BuscarPorTitulo(List<Libro> lista, string titulo)
        {
            foreach (var libro in lista)
            {
                if (libro.Titulo.ToLower() == titulo.ToLower())
                    return libro; // Encontrado
            }

            return null; // No encontrado
        }

        public static void BuscarLibro(List<Libro> libros)
        {
            Console.Write("\nIngrese el título a buscar: ");
            string tituloBuscado = Console.ReadLine();

            var encontrado = BuscarPorTitulo(libros, tituloBuscado);

            if (encontrado != null)
            {
                Console.WriteLine("\n¡Libro encontrado!");
                Console.WriteLine(encontrado);
            }
            else
            {
                Console.WriteLine("\nNo se encontró el libro.");
            }
        }

        public static void MostrarLibros(List<Libro> libros)
        {
            Console.WriteLine("\nLISTA DE LIBROS:");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
        }



    }
}
