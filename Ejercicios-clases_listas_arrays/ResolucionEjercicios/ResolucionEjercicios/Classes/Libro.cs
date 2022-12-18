using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set;}
        public int Paginas { get; set; }
        public bool WasRead { get; set; }

        public Libro(string nombre, int paginas)
        {
            Nombre = nombre;
            Autor = "Anónimo";
            Paginas = paginas;
            WasRead = false;
        }

        public Libro(string nombre, string autor, int paginas, bool wasRead)
        {
            Nombre = nombre;
            Autor = autor;
            Paginas = paginas;
            WasRead = wasRead;
        }

        
    }
}
