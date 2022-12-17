using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Smartphone
    {
        private bool encendido;
        private int volumen;
        private bool silencio;
        private int brillo;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Estado { get { return encendido; } }
        public int Volumen { get { return volumen; } }
        public bool Silencio { get { return silencio; } }
        public int Brillo { get { return brillo; } }

        public Smartphone(string marca, string modelo) 
        { 
            Marca= marca;
            Modelo= modelo;
            encendido = false;
            volumen = 50;
            silencio= false;
            brillo = 50;
        }

        public void encender()
        {
            if(!encendido)
            {
                encendido = true;
                Console.WriteLine("Smartphone encendido");
            }
            else
            {
                encendido = false;
                Console.WriteLine("Smarphone apagado");
            }
        }

        public void subirVolumen()
        {
            if(volumen < 100)
                volumen += 5;
            else
                Console.WriteLine("Volumen al máximo");
        }

        public void bajarVolumen()
        {
            if(volumen > 0)
                volumen -= 5;
            else
            {
                silencio = true;
                Console.WriteLine("Volumen al minimo - En silencio");
            }
        }

        public void silenciar()
        {
            if(silencio)
            {
                silencio = false;
                Console.WriteLine("Volumen activado");
            }
            else 
            {
                silencio = true;
                Console.WriteLine("Silenciado");
            }
        }

        public void aumentarBrillo()
        {
            if (brillo < 100)
                brillo += 10;
            else
                Console.WriteLine("Brillo al máximo");
        }

        public void reducirBrillo()
        {
            if (brillo > 10)
                brillo -= 10;
            else
                Console.WriteLine("Brillo al minimo");
        }
    }
}
