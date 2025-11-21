using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace módulo_de_búsqueda.Ejercicio2
{
    public class Autor
    {
        
            public string Nombre { get; set; }

            public Autor(string nombre)
            {
                Nombre = nombre;
            }

            public override string ToString()
            {
                return Nombre;
            }
        

    }
}
