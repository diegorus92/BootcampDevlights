// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Devlights!\n");


//Ejercicio 1/////////////////////////
#region Ejercicio_1
Console.WriteLine("\nEJERCICIO 1");
void mayorA(int entrada,int objetivo)
{
    if (entrada > objetivo)
        Console.WriteLine("El valor ingresado es mayor a " + objetivo);
    else
        Console.WriteLine("El valor ingresado es menor a " + objetivo);
}

Console.WriteLine("Ingrese un número entero... ");
string entero = Console.ReadLine();
mayorA(int.Parse(entero), 100);
Console.WriteLine("---------------------------");
#endregion

//Ejercicio 2//////////////////////////
#region Ejercicio_2
Console.WriteLine("\nEJERCICIO 2");

bool esPar(int numero)
{
    if(numero % 2 == 0)
        return true;
    else
        return false;
}

Console.Write("Ingrese un numero: ");
string entero1 = Console.ReadLine();
if (esPar(int.Parse(entero1)))
    Console.WriteLine("El número ingresado es par");
else
    Console.WriteLine("El número ingresado es impar");

Console.WriteLine("---------------------------");
#endregion


//Ejercicio 3//////////////////////////////
#region Ejercicio_3
Console.WriteLine("\nEJERCICIO 3");

bool esDobleImpar(int numero)
{
    if((numero/2)%2 != 0) return true;
    else return false;
}

Console.Write("Ingrese un entero: ");
if (esDobleImpar(int.Parse(Console.ReadLine())))
    Console.WriteLine("El número ingresado es el doble de un impar");
else
    Console.WriteLine("El número ingresado NO es el doble de un impar");

Console.WriteLine("---------------------------");
#endregion


//Ejercicio 4///////////////////////////////
#region Ejercicio_4
Console.WriteLine("\nEJERCICIO 4");

string aRomano(int numero)
{
    switch (numero)
    {
        case 1: return "I";
        case 2: return "II";
        case 3: return "III";
        case 4: return "IV";
        case 5: return "V";
        case 6: return "VI";
        case 7: return "VII";
        case 8: return "VIII";
        case 9: return "IX";
        case 10: return "X";
        default: return "El numero debe ser del 1 al 10";
    }
}

Console.Write("Ingrese un número del 1 al 10: ");
Console.WriteLine(aRomano(int.Parse(Console.ReadLine())));
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 5///////////////////////////////////////
#region Ejercicio_5
Console.WriteLine("\nEJERCICIO 5");

void elMenor()
{
    int edad1;
    string nombre1;

    int edad2;
    string nombre2;

    Console.Write("Ingrese la edad de la primera persona: ");
    edad1 = int.Parse(Console.ReadLine());
    Console.Write("\nIngrese el nombre de la primera persona: ");
    nombre1 = Console.ReadLine();

    Console.Write("\nIngrese la edad de la segunda persona: ");
    edad2 = int.Parse(Console.ReadLine());
    Console.Write("\nIngrese el nombre de la segunda persona: ");
    nombre2 = Console.ReadLine();

    if (edad1 < edad2)
        Console.WriteLine(nombre1 + " es el menor y tiene una diferencia de edad de " + (edad2 - edad1) + " años con " + nombre2);
    else if (edad1 > edad2)
        Console.WriteLine(nombre2 + " es el menor y tiene una diferencia de edad de " + (edad1 - edad2) + " años con " + nombre1);
    else
        Console.WriteLine("Las edades entre " + nombre1 + " y " + nombre2 + " son las mismas");
}

elMenor();
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 6////////////////////////////////
#region Ejercicio_6
Console.WriteLine("\nEJERCICIO 6");

string triangulo(float lado1, float lado2, float lado3)
{
    if (lado1 == lado2 && lado1 == lado3)
        return "equilátero";
    else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
        return "escaleno";
    else 
        return "isósceles";
}

float perimetro(float lado1, float lado2, float lado3)
{
    return (lado1 + lado2 + lado3);
}

float area(float lado1, float lado2)
{
    return ((lado1 * lado2) / 2);
}

float l1, l2, l3;
Console.Write("Ingrese el primer lado del triángulo: ");
l1 = float.Parse(Console.ReadLine());

Console.Write("\nIngrese el segundo lado del triángulo: ");
l2 = float.Parse(Console.ReadLine());

Console.Write("\nIngrese el tercer lado del triángulo: ");
l3 = float.Parse(Console.ReadLine());

Console.WriteLine("\n\n El triángulo es de tipo: "+triangulo(l1, l2, l3));
Console.WriteLine("El perímetro de triángulo es: "+ perimetro(l1,l2,l3));
Console.WriteLine("El área del triángulo es: "+area(l1,l2));
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 7/////////////////////////////////////
#region Ejercicio_7
Console.WriteLine("\nEJERCICIO 7");

void desglosar(int monto)
{
    int contMil = 0;
    int contQuinientos = 0;
    int contCien = 0;
    int contCincuenta = 0;
    int contVeinte = 0;
    int contDIez = 0;
    int contCinco = 0;
    int contDos = 0;
    int contUno = 0;

    while(monto >= 1000)
    {
        contMil++;
        monto -= 1000;
    }

    while(monto >= 500)
    {
        contQuinientos++;
        monto-= 500;
    }

    while(monto >= 100)
    {
        contCien++;
        monto-= 100;
    }
    
    while(monto >= 50)
    {
        contCincuenta++;
        monto -= 50;
    }

    while(monto >= 20)
    {
        contVeinte++;
        monto-= 20;
    }

    while(monto >= 10)
    {
        contDIez++;
        monto-= 10;
    }

    while(monto >= 5)
    {
        contCinco++;
        monto-= 5;
    }

    while(monto >= 2)
    {
        contDos++;
        monto-= 2;
    }

    while(monto >= 1)
    {
        contUno++;
        monto-= 1;
    }

    Console.WriteLine(
        "1000 = "+contMil+
        "\n500 = "+contQuinientos+
        "\n100 = "+contCien+
        "\n50 = "+contCincuenta+
        "\n20 = "+contVeinte+
        "\n10 = "+contDIez+
        "\n5 = "+contCinco+
        "\n2 = "+contDos+
        "\n1 = "+contUno);
}

Console.Write("Ingrese un monto: ");
desglosar(int.Parse(Console.ReadLine()));
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 8////////////////////////////
#region Ejercicio_8
Console.WriteLine("\nEJERCICIO 8");

Console.Write("Ingrese un número: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
for(int i = 1; i <= n; i++)
    Console.WriteLine(i);
Console.WriteLine("---------------------------");
#endregion

//Ejercicio 9////////////////////////////
#region Ejercicio_9
Console.WriteLine("\nEJERCICIO 9");

int sumatoria()
{
    int acumulador = 0;

    for(int i = 0; i < 15; i++)
    {
        Console.Write("\n" + (i + 1)+"=> Ingrese un número: ");
        acumulador += int.Parse(Console.ReadLine());
    }
    return acumulador;
}

Console.WriteLine("Suma total = " + sumatoria());
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 10///////////////////////////////////////
#region Ejercicio_10
Console.WriteLine("\nEJERCICIO 10");

void multiploDeTres()
{
    int numero;
    for(int i = 0; i < 5; i++)
    {
        Console.Write("Ingresa un número: ");
        numero = int.Parse(Console.ReadLine());
        if (numero % 3 == 0)
            Console.WriteLine("El número " + numero + " es multiplo de 3\n");
    }
}

multiploDeTres();
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 11/////////////////////////////////////////
#region Ejercicio_11
Console.WriteLine("\nEJERCICIO 11");

void comprobarPassword(string passOriginal)
{
    string entrada;
    do
    {
        Console.Write("Vuelva a ingresar la contraseña: ");
        entrada= Console.ReadLine();
        if (entrada != passOriginal)
            Console.WriteLine("Las contraseñas no coinciden!");
    }while(entrada != passOriginal);
    Console.WriteLine("FELICIDADES! Las contraseñas coinciden :)");
}

Console.WriteLine("Ingrese una contraseña");
comprobarPassword(Console.ReadLine());
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 12///////////////////////////////////////////////////
#region Ejercicio_12
Console.WriteLine("\nEJERCICIO 12");

void comprobarPasswordConLimite(string passOriginal, int intentos)
{
    string entrada;

    for(int i=intentos; i > 0; i--)
    {
        Console.Write("Vuelva a ingresar la contraseña("+i+" intentos): ");
        entrada = Console.ReadLine();
        if(entrada == passOriginal)
        {
            Console.WriteLine("FELICIDADES! Las contraseñas coinciden :)");
            break;
        }
        Console.WriteLine("Contraseña incorrecta");
    }
    Console.WriteLine("Fin de la aplicación");
}

Console.WriteLine("Ingrese una contraseña");
comprobarPasswordConLimite(Console.ReadLine(), 3);
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 13/////////////////////////////////////////////////////////////
#region Ejercicio_13
Console.WriteLine("\nEJERCICIO 13");

void adivinarNumero(int numero)
{
    int entrada;
    do
    {
        Console.Write("Adivine el número: ");
        entrada = int.Parse(Console.ReadLine());
        if (entrada != numero)
            Console.WriteLine("No es el número, vuelve a intentarlo.\n");
    }while(entrada != numero);
    Console.WriteLine("Acertaste!!! :D");
}

adivinarNumero(100);
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 14///////////////////////////////////////
#region Ejercicio_14
Console.WriteLine("\nEJERCICIO 14");

void adivinarNumeroConPistas(int numero)
{
    int entrada;
    int contadorPistas = 0;
    do
    {
        Console.Write("Adivine el número: ");
        entrada = int.Parse(Console.ReadLine());
        if (entrada != numero)
        {
            Console.WriteLine("No es el número, vuelve a intentarlo.");
            contadorPistas++;

            if (entrada < numero)
                Console.WriteLine("PISTA: El número es mas grande\n");
            else
                Console.WriteLine("PISTA: El número es mas pequeño\n");
        }
            
    } while (entrada != numero);
    Console.WriteLine("Acertaste!!! :D");
    Console.WriteLine("Intentos: " + contadorPistas);
}

adivinarNumeroConPistas(100);
Console.WriteLine("---------------------------");
#endregion


//Ejercicio 15///////////////////////////////////////
#region Ejercicio_15
Console.WriteLine("\nEJERCICIO 15");

void sumatoria2(string condicionFin)
{
    int acumulador = 0;
    string entrada = "";

    while(entrada != condicionFin){
        Console.Write("Ingrese un numero para sumar o escriba '"+condicionFin+"' para terminar: ");
        entrada = Console.ReadLine();
        if(entrada != condicionFin)
        {
            acumulador += int.Parse(entrada);
        }
    }

    Console.WriteLine("Resultado final de la sumatoria: "+acumulador);
}

sumatoria2("fin");
Console.WriteLine("---------------------------");
#endregion



