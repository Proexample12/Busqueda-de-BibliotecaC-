using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace módulo_de_búsqueda
{
    public class BúsquedaFechas
    {
        public class Libros
        {
            public string Titulo { get; set; }

            public int Año { get; set; }
            public Libros(string titulo, int año)
            {
                Titulo = titulo;
                Año = año;
            }

        }
        List<Libros> libros = new List<Libros>();
        /// <summary>
        /// documentacion
        /// </summary>



        public void Buscar()
        {
            libros.Add(new Libros("Cien años de soledad", 1967));
            libros.Add(new Libros("El Principito", 1943));
            libros.Add(new Libros("Don Quijote de la Mancha", 1605));
            libros.Add(new Libros("Harry Potter y la piedra filosofal", 1997));
            libros.Add(new Libros("El Alquimista", 1988));
            libros.Add(new Libros("Orgullo y prejuicio", 1813));
            libros.Add(new Libros("1984", 1949));
            libros.Add(new Libros("El hobbit", 1937));
            libros.Add(new Libros("Crimen y castigo", 1866));
            libros.Add(new Libros("El nombre del viento", 2007));
            libros.Add(new Libros("It", 1986));
            libros.Add(new Libros("La sombra del viento", 2001));
            libros.Add(new Libros("Fahrenheit 451", 1953));
            libros.Add(new Libros("EL viejo y el mar", 1952));
        }
        public void ObtenerExtremos()
        {

            Libros masAntiguo = libros.OrderBy(l => l.Año).First();


            Libros masReciente = libros.OrderByDescending(l => l.Año).First();

            Console.WriteLine("Libro más antiguo:");
            Console.WriteLine($"{masAntiguo.Titulo} - {masAntiguo.Año}");

            Console.WriteLine("\nLibro más reciente:");
            Console.WriteLine($"{masReciente.Titulo} - {masReciente.Año}");
        }
        public static void Ejecutar()
        {
            BúsquedaFechas busqueda = new BúsquedaFechas();
            busqueda.Buscar(); // llena la lista
            busqueda.ObtenerExtremos();
        }

    }
}
