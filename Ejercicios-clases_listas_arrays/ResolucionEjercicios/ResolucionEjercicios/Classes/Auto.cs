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
        private double velocidad;
        private double velocidadAnterior; //Velocidad Inicial
        private int aceleracion; //%
        private int desaceleracion; //%
        private List<Persona> pasajeros;
        private Mascota mascota;


        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Motor { get; set; }
        public Persona Conductor { get; set; }
        public int Capacidad { get; set; }
        public Mascota Mascota 
        {
            get 
            { 
                return mascota; 
            }
            set 
            {
                if (Conductor != null)
                {
                    if (pasajeros.Count < Capacidad && value.Tamanio.ToLower() == "grande")
                    {
                        mascota = value;
                        Capacidad--;
                        Console.WriteLine("Mascota " + mascota.Tamanio + " agregada. Capacidad reducida a "+Capacidad);
                    }
                    else if(pasajeros.Count == Capacidad && value.Tamanio.ToLower() == "grande")
                        Console.WriteLine("Espacio insuficiente");

                    if((pasajeros.Count <= Capacidad && pasajeros.Count > 0) && value.Tamanio.ToLower() == "pequeña")
                    {
                        mascota = value;
                        pasajeros[0].MascotaEnRegazo = mascota;
                        Console.WriteLine("Mascota " + pasajeros[0].MascotaEnRegazo.Tamanio+" agregada sobre el regazo de " + pasajeros[0].Nombre);
                    }
                    else if(pasajeros.Count == 0 && value.Tamanio.ToLower() == "pequeña")
                    {
                        mascota = value;
                        Console.WriteLine("Mascota sobre el asiento. No hay pasajeros abordo");
                    }
                }
                else
                    Console.WriteLine("Se debe agregar un conductor primero");
            }
        }
        

        public Auto(string modelo, string marca, string motor)
        {
            Modelo = modelo;
            Marca = marca;
            Motor = motor;

            encendido = false;
            velocidad = 0;
            velocidadAnterior = 0;
            aceleracion = 10;
            desaceleracion = 20;
            pasajeros = new List<Persona>();
        }

        /// <summary>
        ///     Alterna el estado del motor entre encendido y apagado
        /// </summary>
        public void encenderMotor()
        {
            if (Conductor != null && Conductor.obtenerEdad() >= 18)
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
            else
                Console.WriteLine("No hay conductor para encender el coche o el conductor es menor de edad");
            
        }

        public void acelerar()
        {
            if (encendido)
            {
                if(velocidad == 0)
                {
                    velocidad +=  aceleracion;
                    velocidadAnterior = 0;
                }
                else if(velocidad >= aceleracion)
                {
                    velocidadAnterior = velocidad;
                    velocidad += (double) (velocidad * aceleracion) / 100;
                }
            }
            else
                Console.WriteLine("El motor está apagado");
        }

        public void frenar()
        {
            if (velocidad > 0)
            {
                velocidadAnterior = velocidad;
                velocidad -= (double) desaceleracion;
                if (velocidad < 0)
                    velocidad = 0;
            }
            else
                Console.WriteLine("El coche está detenido");
        }

        public double obtenerVelocidad()
        {
            return velocidad;
        }

        public double obtenerAceleracion()
        {
            return (velocidad - velocidadAnterior);
        }

        public void agregarPasajero(Persona pasajeroNuevo)
        {
            if (Capacidad > 0 && pasajeros.Count < Capacidad)
            {
                pasajeros.Add(pasajeroNuevo);
                Console.WriteLine("Pasajero/a " + pasajeroNuevo.Nombre + " agregado");
            }
            else
                Console.WriteLine("Limite de pasajeros excedido");
        }

        public void obtenerLugarMascota()
        {
            if (mascota != null)
            {
                if (pasajeros.Count > 0)
                {
                    bool mascotaEncontrada = false;
                    foreach (Persona p in pasajeros)
                    {
                        if (p.MascotaEnRegazo != null)
                        {
                            Console.WriteLine("Mascota " + p.MascotaEnRegazo.Nombre + " sobre el regazo de " + p.Nombre);
                            mascotaEncontrada = true;
                            break;
                        }
                    }
                    if (!mascotaEncontrada)
                        Console.WriteLine("no se encontró mascota");
                }
                else
                    Console.WriteLine("La mascota está sobre el asiento, no hay ningun pasajero abordo");
            }
            else
                Console.WriteLine("No hay ninguna mascota abordo");
            
        }

        public void cambiarMascotaDeLugar()
        {
            int indiceActual = 0;

            for(int i = 0; i < pasajeros.Count; i++)
            {
                if (pasajeros[i].MascotaEnRegazo != null)
                {
                    indiceActual = i;
                    mascota = pasajeros[i].MascotaEnRegazo;
                    Console.WriteLine("Mascota "+ mascota.Nombre + " hallada en Indice: " + indiceActual +"; sobre " + pasajeros[indiceActual].Nombre);
                    break;
                }
            }

            if (mascota != null)
            {
                if((indiceActual+1) < pasajeros.Count)
                {
                    pasajeros[indiceActual].MascotaEnRegazo = null;
                    pasajeros[indiceActual + 1].MascotaEnRegazo = mascota;
                    Console.WriteLine("Mascota " + mascota.Nombre + " cambia al regazo de " + pasajeros[indiceActual + 1].Nombre);
                }
                else
                {
                    pasajeros[indiceActual].MascotaEnRegazo = null;
                    pasajeros[0].MascotaEnRegazo = mascota;
                    Console.WriteLine("Mascota " + mascota.Nombre + " vuelve al regazo de " + pasajeros[0].Nombre);
                }
            }
            else
                Console.WriteLine("No se encontró mascota para cambiar de lugar");
        }

        private void bajarMascota()
        {
            for(int i = 0; i < pasajeros.Count; i++) 
            {
                if (pasajeros[i].MascotaEnRegazo!= null) 
                {
                    pasajeros[i].MascotaEnRegazo = null;
                    mascota = null;
                    Console.WriteLine("Se ha bajado la mascota");
                    break;
                }
            }
        }

        public void bajarPasajeros()
        {
            if (velocidad <= 0)
            {
                if (mascota != null)
                    bajarMascota();

                pasajeros.Clear();
                Console.WriteLine("Se han bajado todos los pasajeros");
            }
            else
                Console.WriteLine("El coche debe estar detenido para bajar pasajeros");
        }

        public void bajarConductor()
        {
            if (velocidad <= 0)
            {
                if (!encendido)
                {
                    Conductor = null;
                    Console.WriteLine("Se bajo el conductor");
                }
                else
                    Console.WriteLine("El motor debe apagarse antes de bajar el conductor");
            }
            else
                Console.WriteLine("El coche debe estar detenido para bajar conductor");
        }
    }
}
