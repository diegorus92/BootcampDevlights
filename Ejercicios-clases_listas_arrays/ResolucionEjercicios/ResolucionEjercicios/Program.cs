using ResolucionEjercicios.Classes;

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