using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Mascota
    {
        private int energia;

        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Energia 
        { 
            get 
            {
                return energia;
            } 
        }

        public Mascota(string nombre, string tipo)
        {
            Nombre= nombre;
            Tipo= tipo;
            energia = 25;
        }

        public void alimentar()
        {
            if(energia == 100) { 
                Console.WriteLine("Energía al máximo");
                energia = 100;
            }
            else 
            {
                Console.WriteLine("Mascota alimentada: +30% energía");
                if ((energia + 30) > 100)
                    energia = 100;
                else
                    energia += 30;
            }
        }

        public void correr()
        {
            if (energia > 20)
            {
                energia -= 10;
                Console.WriteLine(Nombre + " ha corrido: -10% energía");
            }
            else
                Console.WriteLine(Nombre + " No tiene suficiente energía para correr");
        }
    }
}
