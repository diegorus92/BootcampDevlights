using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Auto
    {
        private bool encendido;

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Motor { get; set; }

        public Auto(string modelo, string marca, string motor)
        {
            Modelo = modelo;
            Marca = marca;
            Motor = motor;

            encendido = false;
        }

        public void encenderMotor()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("Motor encendido");
            }
            else
            {
                encendido = false;
                Console.WriteLine("Motor apagado");
            }
        }
    }
}
