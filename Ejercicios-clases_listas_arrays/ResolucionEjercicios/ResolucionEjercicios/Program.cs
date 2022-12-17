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

#region Ejercicio_3_4
Persona persona = new Persona("Martin", "Castro");
Console.WriteLine("Persona: "+persona.obtenerNombreCompleto());
DateTime fn = new DateTime(1992, 3, 23);
persona.FechaNacimiento = fn;
Console.WriteLine("Edad: " + persona.obtenerEdad());
#endregion
*/

#region Ejercicio_5
Auto auto = new Auto("Uno", "Fiat", "1.5");
auto.encenderMotor();
auto.encenderMotor();
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