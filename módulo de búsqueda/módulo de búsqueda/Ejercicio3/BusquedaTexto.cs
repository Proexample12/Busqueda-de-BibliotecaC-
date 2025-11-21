using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace módulo_de_búsqueda
{

        public class BúsquedaTexto
    {
            // -----------------------------------
            // Clase Libro
            // -----------------------------------
            public class Libro
            {
                public string Titulo { get; set; }
                public int AnioPublicacion { get; set; }
                public string Descripcion { get; set; }

                public Libro(string titulo, int anio, string descripcion)
                {
                    Titulo = titulo;
                    AnioPublicacion = anio;
                    Descripcion = descripcion;
                }
            }

            // -----------------------------------
            // ESTE ES TU "MAIN"
            // -----------------------------------
            public static void Ejecutar()
            {
                List<Libro> libros = ObtenerLibros();

                Console.WriteLine("Ingrese una palabra, frase o texto para buscar en las descripciones:");
                string textoBusqueda = Console.ReadLine();

                List<Libro> resultados = BuscarLibros(libros, textoBusqueda);

                Console.WriteLine("\nLibros que coinciden:");
                if (resultados.Count == 0)
                {
                    Console.WriteLine("No se encontraron coincidencias.");
                }
                else
                {
                    foreach (Libro libro in resultados)
                    {
                        Console.WriteLine($"- {libro.Titulo} ({libro.AnioPublicacion})({ libro.Descripcion})");
                    }
                }

               
                Console.ReadKey();
            }

            // -----------------------------------
            // Métodos auxiliares
            // -----------------------------------

            public static void MostrarLibro(Libro libro)
            {
                Console.WriteLine($"Título: {libro.Titulo}");
                Console.WriteLine($"Año: {libro.AnioPublicacion}");
                Console.WriteLine($"Descripción: {libro.Descripcion}");
            }

            public static List<Libro> ObtenerLibros()
            {
                return new List<Libro>
            {
                new Libro("Cien años de soledad", 1967, "Historia de la familia Buendía en Macondo"),
                new Libro("El Principito", 1943, "Un niño viaja por planetas aprendiendo sobre la vida"),
                new Libro("Don Quijote de la Mancha", 1605, "Un hidalgo que enloquece con los libros de caballería"),
                new Libro("Harry Potter y la piedra filosofal", 1997, "Un niño descubre que es mago y entra a una escuela de magia"),
                new Libro("El Alquimista", 1988, "Un pastor sigue su leyenda personal para encontrar un tesoro"),
                new Libro("Orgullo y prejuicio", 1813, "Historia de amor con diferencias sociales"),
                new Libro("1984", 1949, "Una sociedad controlada por un gobierno totalitario"),
                new Libro("El hobbit", 1937, "Una aventura con enanos, dragones y un anillo mágico"),
                new Libro("Crimen y castigo", 1866, "Un joven comete un crimen y enfrenta su culpa"),
                new Libro("El nombre del viento", 2007, "La historia de Kvothe un músico mago legendario"),
                new Libro("It", 1986, "Un grupo de amigos enfrenta a una entidad maligna"),
                new Libro("La sombra del viento", 2001, "Un libro misterioso en el cementerio de los libros olvidados"),
                new Libro("Fahrenheit 451", 1953, "En una sociedad futura los libros son quemados"),
                new Libro("El viejo y el mar", 1952, "Un pescador lucha contra un pez gigante en el mar")
            };
            }

            public static List<Libro> BuscarLibros(List<Libro> libros, string texto)
            {
                return libros.Where(libro =>
                    libro.Descripcion.ToLower().Contains(texto.ToLower()) ||
                    libro.Titulo.ToLower().Contains(texto.ToLower())
                ).ToList();
            }

           
        }

    }

