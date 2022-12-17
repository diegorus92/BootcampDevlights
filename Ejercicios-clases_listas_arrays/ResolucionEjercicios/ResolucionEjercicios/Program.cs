using ResolucionEjercicios.Classes;

/*
#region Ejercicio_1
PrimeraGuia pg = new PrimeraGuia();

Console.WriteLine("Ejercicio 1_guia 1");
Console.WriteLine("Ingrese un número");
pg.mayorA(int.Parse(Console.ReadLine()), 100);
Console.WriteLine("///////////////////////");


pg.sumatoria2("fin");
Console.WriteLine("///////////////////////");
#endregion

#region Ejercicio_2
Console.WriteLine("Ejercicio 2");
Cuadrado c = new Cuadrado(3.3);
Console.WriteLine("El Área del cuadrado es: " + c.getArea());
Console.WriteLine("//////////////////////////");
#endregion


#region Ejercicio_3_4_10
Persona persona = new Persona("Martin", "Castro");
Console.WriteLine("Persona: "+persona.obtenerNombreCompleto());
DateTime fn = new DateTime(1992, 3, 23);
persona.FechaNacimiento = fn;
Console.WriteLine("Edad: " + persona.obtenerEdad());

persona.SmartPhone = new Smartphone("Motorola", "Moto Z");
Console.WriteLine("Celular de "+persona.Nombre+": "+persona.SmartPhone.Marca+" "+persona.SmartPhone.Modelo);
Console.WriteLine("///////////////////////");
#endregion


#region Ejercicio_5_9_11_12
Auto auto = new Auto("Uno", "Fiat", "1.5");

auto.Conductor = persona;
//auto.Conductor.FechaNacimiento = new DateTime(2010, 5, 5); //Hago que sea menor de edad para probar
Console.WriteLine("Conductor: "+auto.Conductor.Nombre+"; "+auto.Conductor.obtenerEdad()+" años");


auto.encenderMotor();
auto.encenderMotor();

auto.encenderMotor();
auto.acelerar();
Console.WriteLine("Velocidad: " + auto.obtenerVelocidad() + "km/h");
Console.WriteLine("Aceleracion: "+auto.obtenerAceleracion()+"km/h");

auto.acelerar();
auto.acelerar();
auto.acelerar();
Console.WriteLine("Velocidad: " + auto.obtenerVelocidad() + "km/h");
Console.WriteLine("Aceleracion: " + auto.obtenerAceleracion() + "km/h");

auto.frenar();
auto.frenar();
Console.WriteLine("Velocidad: " + auto.obtenerVelocidad() + "km/h");
Console.WriteLine("Aceleracion: " + auto.obtenerAceleracion() + "km/h");

auto.Capacidad = 2;
auto.agregarPasajero(new Persona("Ruben", "Ricardo"));
auto.agregarPasajero(new Persona("Pablo", "Gomez"));
auto.agregarPasajero(new Persona("Romina", "Sanchez"));


Console.WriteLine("////////////////////////////////////");
#endregion


#region Ejercicio_6_7
Mascota mascota = new Mascota("FLuffy", "Gato");
mascota.correr();
Console.WriteLine("Energía de " + mascota.Nombre + ": " + mascota.Energia + "%");
mascota.correr();
Console.WriteLine("Energía de " + mascota.Nombre + ": " + mascota.Energia + "%");
mascota.alimentar();
Console.WriteLine("Energía de " + mascota.Nombre + ": " + mascota.Energia+"%");
mascota.alimentar();
Console.WriteLine("Energía de " + mascota.Nombre + ": " + mascota.Energia + "%");
mascota.correr();
Console.WriteLine("Energía de " + mascota.Nombre + ": " + mascota.Energia + "%");
Console.WriteLine("////////////////////////////////////");
#endregion

#region Ejercicio_8
Smartphone smart = new Smartphone("Samsung", "A10");
Console.WriteLine("Telefono enciendido?: "+smart.Estado);
smart.encender();
Console.WriteLine("Telefono enciendido?: " + smart.Estado); 

Console.WriteLine("Volumen inicial: "+smart.Volumen);
smart.subirVolumen();
smart.subirVolumen();
smart.subirVolumen();
smart.bajarVolumen();
Console.WriteLine("Volumen final: " + smart.Volumen);

Console.WriteLine("Brillo inicial: "+smart.Brillo);
smart.aumentarBrillo();
smart.reducirBrillo();
smart.reducirBrillo();
Console.WriteLine("Brillo final: " + smart.Brillo);

Console.WriteLine("Smartphone silenciado?: "+smart.Silencio);
smart.silenciar();
Console.WriteLine("Smartphone silenciado?: " + smart.Silencio);
smart.silenciar();
Console.WriteLine("Smartphone silenciado?: " + smart.Silencio);
Console.WriteLine("////////////////////////////////////");
#endregion
*/

#region Ejercicio_13
Auto auto2 = new Auto("Fiat", "Palio Weekend", "1.4");
auto2.Capacidad = 4;

Persona conductor = new Persona("Manuel", "Barrios");
conductor.FechaNacimiento = new DateTime(2000, 5, 25);

//Pasajeros
Persona pasajero1 = new Persona("Rodrigo", "Martinez");
Persona pasajero2 = new Persona("Sara", "Martinez");
Persona pasajero3 = new Persona("Yumiko", "Takahashi");

Mascota mascota2 = new Mascota("Dingo", "Perro");
mascota2.Tamanio = "Pequeña";

//      Prueba
auto2.Conductor = conductor;
auto2.agregarPasajero(pasajero1);
auto2.agregarPasajero(pasajero2);
auto2.agregarPasajero(pasajero3);
auto2.Mascota = mascota2;

auto2.cambiarMascotaDeLugar();
auto2.obtenerLugarMascota();
auto2.cambiarMascotaDeLugar();
auto2.obtenerLugarMascota();
auto2.cambiarMascotaDeLugar();
auto2.obtenerLugarMascota();
auto2.cambiarMascotaDeLugar();
auto2.obtenerLugarMascota();

#endregion