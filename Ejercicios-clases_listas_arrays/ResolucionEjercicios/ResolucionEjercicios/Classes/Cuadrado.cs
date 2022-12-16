using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class Cuadrado
    {
        public double Lado { get; set; }

        public Cuadrado(double lado) 
        {
            Lado = lado;
        }

        public double getArea()
        {
            return Math.Pow(Lado, 2);
        }
    }
}
