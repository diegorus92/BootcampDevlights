using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public DateTime FechaNacimiento { get; set; }
        public Smartphone SmartPhone { get; set; }
        public Mascota MascotaEnRegazo { get; set; }

        public Persona(string nombre, string apellido) 
        {
            Nombre= nombre;
            Apellido= apellido;
        }

        public string obtenerNombreCompleto()
        {
            return Nombre+ " "+Apellido;
        }

        public int obtenerEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }
}
