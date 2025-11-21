using System;

namespace módulo_de_búsqueda
{
    

    internal static class Menu
    {
        public static void Mostrar()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("===== Módulo de Búsqueda =====");
                Console.WriteLine("1. Búsqueda Lineal de Libros");
                Console.WriteLine("2. Búsqueda Binaria de Autores");
                Console.WriteLine("3. Búsqueda de Coincidencias de Texto");
                Console.WriteLine("4. Libro Más Nuevo y Más Antiguo");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out opcion))
                {
                    Console.WriteLine("Entrada no válida. Intente nuevamente.");
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        
                        BusquedaLineal.Ejecutar();
                        break;
                    case 2:
                        
                        BúsquedaBinaria.Ejecutar();
                        break;
                    case 3:
                        
                        BúsquedaTexto.Ejecutar();
                        break;
                    case 4:
                        
                        BúsquedaFechas.Ejecutar();
                        break;
                    case 5:
                        
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente otra vez.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
