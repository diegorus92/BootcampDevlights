using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ResolucionEjercicios.Classes
{
    public class Estudiante: Persona
    {
        private List<Libro> librosLeidos;
        private List<Libro> librosNoLeidos;

       public Estudiante(string nombre, string apellido): base(nombre, apellido) 
       {
            librosLeidos= new List<Libro>();
            librosNoLeidos= new List<Libro>(); 
        }

        public void agregarLibro(Libro libro)
        {
            if(libro.WasRead)
                librosLeidos.Add(libro);
            else
                librosNoLeidos.Add(libro);
        }

        public void quitarLibroLeido(string nombre)
        {
            bool flag = false;

            for(int i = 0; i < librosLeidos.Count; i++) 
            {
                if (librosLeidos[i].Nombre.ToLower() == nombre.ToLower())
                {
                    librosLeidos.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Libro removido de lista de leídos");
            else
                Console.WriteLine("No se encontró libro");
        }

        public void quitarLibroNoLeido(string nombre)
        {
            bool flag = false;

            for (int i = 0; i < librosNoLeidos.Count; i++)
            {
                if (librosNoLeidos[i].Nombre.ToLower() == nombre.ToLower())
                {
                    librosNoLeidos.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Libro removido de lista de no leidos");
            else
                Console.WriteLine("No se encontró libro");
        }

        public void mostrarLibrosLeidos()
        {
            foreach(Libro l in librosLeidos)
            {
                Console.WriteLine("Libro: "+l.Nombre+" -- Autor: "+l.Autor+" -- Páginas: "+l.Paginas+" -- Leído? "+l.WasRead);
            }
        }

        public int paginasTotalesLeidas()
        {
            int total = 0;
            foreach(Libro l in librosLeidos)
                total += l.Paginas;
            return total;
        }

        public int totalLibrosSinLeer()
        {
            return librosNoLeidos.Count();
        }
    }
}
