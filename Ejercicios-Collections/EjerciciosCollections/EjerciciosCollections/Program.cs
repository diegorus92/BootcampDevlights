
#region Ejercicio_1
Console.WriteLine("/////////////////Ejercicio 1/////////////////\n");
List<double> notasExamen = new List<double>() { 8.5, 7.6, 8, 3, 4, 5.7, 6, 8, 10, 9.5 };
int contador = 0;
double acumulador = 0;

foreach(double item in notasExamen)
{
    Console.WriteLine(item);
    contador++;
    acumulador += item;
}

Console.WriteLine("Promedio = "+(acumulador/contador));
Console.WriteLine("//////////////////////////////////\n");
#endregion

#region Ejercicio_2
Console.WriteLine("/////////////////Ejercicio 2/////////////////\n");
int mayores = 0;
int menores = 0;
List<int> edades= new List<int>() { 30, 25, 34, 65, 12, 34, 22, 13, 16, 45, 65, 63, 23, 11, 15, 44, 67, 55, 43, 21 };
foreach(int item in edades)
{
    if (item >= 18)
        mayores++;
    else
        menores++;
}

Console.WriteLine("Mayores de edad: " + mayores + "\nMenores de edad: " + menores);
Console.WriteLine("//////////////////////////////////\n");
#endregion

#region Ejercicio_3
Console.WriteLine("/////////////////Ejercicio 3/////////////////\n");
List<string> estudiantes = new List<string>() { "Alvaro", "Manu", "Octavio", "Romina", "Jose Maria", "Jessica", "Marta" };
string largo = estudiantes[0];
string corto = estudiantes[0];

for (int i = 1; i < estudiantes.Count; i++)
{
    if (estudiantes[i].Length > largo.Length)
        largo = estudiantes[i];
    if (estudiantes[i].Length < corto.Length)
        corto = estudiantes[i];
}
Console.WriteLine("Nombre con mas letras: " + largo);
Console.WriteLine("Nombre con menos letras: " + corto);
Console.WriteLine("//////////////////////////////////\n");
#endregion

#region Ejercicio_4
Console.WriteLine("/////////////////Ejercicio 4/////////////////\n");
List<string> listaSuper = new List<string>() { "huevos", "leche", "azucar" };
string elemento = "";
while (elemento != "fin")
{
    Console.Write("Ingrese un elemento para buscar en lista ['fin' para salir]: ");
    elemento = Console.ReadLine();
    if (elemento == "fin")
        break;
    if(listaSuper.Exists(item => item.ToLower() == elemento.ToLower()))
    {
        Console.WriteLine("El elemento estaba en la lista");
        for(int i = 0; i < listaSuper.Count; i++)
        {
            if (listaSuper[i].ToLower() == elemento.ToLower())
                listaSuper.RemoveAt(i);
        }
    }
    else
    {
        Console.WriteLine("El elemento no estaba en la lista");
        listaSuper.Add(elemento);
    }
} 

foreach(string item in listaSuper)
    Console.WriteLine(item);
Console.WriteLine("//////////////////////////////////\n");

#endregion

#region Ejercicio_5
Console.WriteLine("/////////////////Ejercicio 5/////////////////\n");
int filasColumnas = 5;
int contadorPosicion = 1;
char[,] matriz1 = new char[filasColumnas,filasColumnas];
for(int i = 0; i < filasColumnas; i++)
{
    for(int j = 0; j < filasColumnas; j++)
    {
        if (contadorPosicion % 2 == 0)
            matriz1[i, j] = 'P';
        else
            matriz1[i, j] = 'I';

        contadorPosicion++;
    }
}

for (int i = 0; i < filasColumnas; i++)
{
    for (int j = 0; j < filasColumnas; j++)
    {
        Console.Write(matriz1[i, j]+"  ");
    }
    Console.WriteLine();
}
Console.WriteLine("//////////////////////////////////\n");

#endregion

#region Ejercicio_6
Console.WriteLine("/////////////////Ejercicio 6/////////////////\n");
int semanas = 5;
int dias = 7;
int minimo = 7;
int maximo = 38;
int tempMayor = 0;
int tempMenor = 0;
string diaAlta = "";
string diaBaja = "";

int[,] temperaturas = new int[semanas, dias];
var rand = new Random();
int contadorFecha = 1;

//Carga de temperaturas
for(int i = 0; i < semanas; i++)
{
    for(int j = 0; j < dias; j++)
    {
        temperaturas[i, j] = rand.Next(minimo, maximo);
        contadorFecha++;
        if (contadorFecha > 31)
            break;
    }
    
}

contadorFecha = 1;//Reinicio contador

//Muestra temperaturas del 1 al 31 de mayo
for (int i = 0; i < semanas; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write(temperaturas[i, j] + "  ");
        contadorFecha++;
        if (contadorFecha > 31)
            break;
    }
    Console.WriteLine();
}


////////////A) Temperatura mas alta y mas baja de cada semana
contadorFecha = 0;//Reinicio contador

for (int i = 0; i < semanas; i++)
{
    tempMayor = minimo;
    tempMenor = maximo;
    Console.WriteLine("Semana "+(i+1));
    for (int j = 0; j < dias; j++)
    {
        if (contadorFecha >= 31)
            break;
        if (temperaturas[i,j] > tempMayor)
        {
            tempMayor = temperaturas[i,j];
            switch(j+1)
            {
                case 1:
                    diaAlta = "Lunes";
                    break;
                case 2:
                    diaAlta = "Martes";
                    break;
                case 3:
                    diaAlta = "Miercoles";
                    break;
                case 4:
                    diaAlta = "Jueves";
                    break;
                case 5:
                    diaAlta = "Viernes";
                    break;
                case 6:
                    diaAlta = "Sabado";
                    break;
                case 7:
                    diaAlta = "Domingo";
                    break;
                default: 
                    diaAlta = "indefinido";
                    break;
            }
        }
            
        if (temperaturas[i,j] < tempMenor)
        {
            tempMenor = temperaturas[i, j];
            switch(j + 1)
            {
                case 1:
                    diaBaja = "Lunes";
                break;
                case 2:
                    diaBaja = "Martes";
                break;
                case 3:
                    diaBaja = "Miercoles";
                break;
                case 4:
                    diaBaja = "Jueves";
                break;
                case 5:
                    diaBaja = "Viernes";
                break;
                case 6:
                    diaBaja = "Sabado";
                break;
                case 7:
                    diaBaja = "Domingo";
                break;
                default: 
                    diaBaja = "indefinido";
                break;
            }
        }
        contadorFecha++;
    }

    Console.WriteLine("Temperatura alta --> " + diaAlta + ": " + tempMayor + " °C");
    Console.WriteLine("Temperatura baja --> " + diaBaja + ": " + tempMenor + " °C");
}



////////////B) Promedio de temperatura de cada semana
static int promedioTemperaturasSemana(int[] semana)
{
    int totalTemperaturas = 0;
    int contadorDias = 0;

    foreach(var dia in semana)
    {
        if(dia > 0)
        {
            totalTemperaturas += dia;
            contadorDias++;
        }
        
    }

    return (totalTemperaturas / contadorDias);
}

int[] semana = new int[dias];
for(int i = 0; i < semanas; i++)
{
    for(int j = 0; j < dias; j++)
    {
        semana[j] = temperaturas[i, j];
    }
    Console.WriteLine("Promedio de temperatura de semana "+(i+1)+": "+promedioTemperaturasSemana(semana));
}



//////////////C) Temperatura mas alta del mes y su día
contadorFecha = 0; //Reinicio contador
tempMayor = minimo;

for(int i = 0; i < semanas; i++)
{
    for(int j = 0; j < dias; j++)
    {
        if (contadorFecha >= 31)
            break;
        if (temperaturas[i,j] > tempMayor)
        {
            tempMayor = temperaturas[i,j];
            switch (j + 1)
            {
                case 1:
                    diaAlta = "Lunes";
                    break;
                case 2:
                    diaAlta = "Martes";
                    break;
                case 3:
                    diaAlta = "Miercoles";
                    break;
                case 4:
                    diaAlta = "Jueves";
                    break;
                case 5:
                    diaAlta = "Viernes";
                    break;
                case 6:
                    diaAlta = "Sabado";
                    break;
                case 7:
                    diaAlta = "Domingo";
                    break;
                default:
                    diaAlta = "indefinido";
                    break;
            }
        }
    }
    contadorFecha++;
}

Console.WriteLine("Temperatura mas alta del mes: "+tempMayor+" ("+diaAlta+")");
Console.WriteLine("//////////////////////////////////\n");
#endregion


#region Ejercicio_7
Console.WriteLine("/////////////////Ejercicio 7/////////////////\n");
int filas = 10;
int columnas = 11;
int[,] tablas = new int[filas, columnas];

Console.WriteLine("Tablas del 0 al 9");
//Carga de tabla
for(int i = 0; i < filas; i++)
{
    for(int j = 0; j < columnas; j++)
    {
        tablas[i, j] = i * j;
    }
}

//Muestra de tabla
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(tablas[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine("//////////////////////////////////\n");
#endregion


#region Ejercicio_8
Console.WriteLine("/////////////////Ejercicio 8/////////////////\n");
int tamanio = 10;
int maximoMinas = (tamanio/2);
int minasEncontradas = 0;
int intentosTotales = 3;
int intentosRestantes = intentosTotales;
int filaIngresada = 0;
int columnaIngresada = 0;
char lugarVacio = '*';
char lugarMinado = 'X';
char[,] campo = new char[tamanio,tamanio];
char[,] copiaCampo = new char[tamanio, tamanio];

//Carga de matriz
static void minarCampo (char[,] matriz, int cantMinas, char mina)
{
    Random ubicacionMina = new Random();
    int posicionMinaFila = 0;
    int posicionMinaColumna = 0;

    for (int i = 0; i < cantMinas; i++) //Carga solo de minas (también revela locacion)
    {
        posicionMinaFila = ubicacionMina.Next(matriz.GetLength(0));
        posicionMinaColumna = ubicacionMina.Next(matriz.GetLength(1));

        Console.WriteLine("PosMinaF=" + posicionMinaFila + " PosMinaC=" + posicionMinaColumna);//Revela posicion de minas en fila y columna
                                                                                               //(comentar linea de ser necesario)
        matriz[posicionMinaFila, posicionMinaColumna] = mina;
    }
}

minarCampo(campo, maximoMinas, lugarMinado); //Carga solo de minas

static void llenarCampo(char[,] matriz, char vacio, char mina)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (matriz[i, j] != mina)
                matriz[i, j] = vacio;

        }
    }
}

llenarCampo(campo, lugarVacio, lugarMinado); //Carga lugares no minados

static void copiarCampo(char[,] matrizOriginal, char[,]matrizDestino)
{
    if (matrizOriginal.GetLength(0) == matrizDestino.GetLength(0) && matrizOriginal.GetLength(1) == matrizDestino.GetLength(1))
    {
        for (int i = 0; i < matrizOriginal.GetLength(0); i++)
        {
            for (int j = 0; j < matrizOriginal.GetLength(1); j++)
            {
                matrizDestino[i, j] = matrizOriginal[i, j];
            }
        }
    }
    else
        Console.WriteLine("No se puede copiar. Tamaños entre matrices distintos");
}

copiarCampo(campo, copiaCampo);//Copio el campo original 


//Muestra campo
static void revelarCampo(char[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

revelarCampo(campo); //Comentar esta línea para no revelar el campo al principio del juego



////////////////Bucle del juego///////////////////////////////////////
Console.WriteLine("Comienza Buscaminas...");
do
{
    //Muestra puntuaciones en cada iteracion
    Console.WriteLine("Minas encontradas: "+minasEncontradas);
    Console.WriteLine("Intentos restantes: "+intentosRestantes+"\n\n");

    //Ingresa fila
    Console.Write("Ingrese nro de FILA donde cree que hay una mina (de 0 a "+(tamanio-1)+"): ");
    filaIngresada = int.Parse(Console.ReadLine());
    while (filaIngresada < 0 || filaIngresada >= tamanio)
    {
        Console.WriteLine("\nFila ingresada fuera de rango. La fila va de 0 a " + (tamanio - 1));
        Console.Write("Ingrese nro de FILA donde cree que hay una mina (de 0 a " + (tamanio - 1) + "): ");
        filaIngresada = int.Parse(Console.ReadLine());
    }


    //Ingresa columna
    Console.Write("Ingrese nro de COLUMNA donde cree que hay una mina (de 0 a " + (tamanio - 1) + "): ");
    columnaIngresada = int.Parse(Console.ReadLine());
    while (columnaIngresada < 0 || columnaIngresada >= tamanio)
    {
        Console.WriteLine("\nColumna ingresada fuera de rango. La columna va de 0 a " + (tamanio - 1));
        Console.Write("Ingrese nro de COLUMNA donde cree que hay una mina (de 0 a " + (tamanio - 1) + "): ");
        columnaIngresada = int.Parse(Console.ReadLine());
    }

    if (campo[filaIngresada, columnaIngresada] == lugarMinado)
    {
        Console.WriteLine("Encontraste una mina!!!");
        minasEncontradas++;
        campo[filaIngresada, columnaIngresada] = lugarVacio; //para evitar trampas ;)
    }
    else
    {
        Console.WriteLine("Lugar vació :/");
        intentosRestantes--;
    }

} while (intentosRestantes > 0 && minasEncontradas < maximoMinas);

//Condicion/es de derrota
if (intentosRestantes == 0 && minasEncontradas == 0)
{
    Console.WriteLine("\n\nNo encontraste ninguna mina :(");
    Console.WriteLine("Minas encontradas: " + minasEncontradas);
    Console.WriteLine("Intentos restantes: " + intentosRestantes + "\n\n");
}

if(intentosRestantes == 0 && minasEncontradas > 0)
{
    Console.WriteLine("\n\nEncontraste algunas minas, nada mal :|");
    Console.WriteLine("Minas encontradas: " + minasEncontradas);
    Console.WriteLine("Intentos restantes: " + intentosRestantes + "\n\n");
}

//Condicion de victoria
if(intentosRestantes > 0 && minasEncontradas == maximoMinas)
{
    Console.WriteLine("\n\nFelicidades! encontraste todas las minas :D");
    Console.WriteLine("Minas encontradas: " + minasEncontradas);
    Console.WriteLine("Intentos restantes: " + intentosRestantes + "\n\n");
}

revelarCampo(copiaCampo);
Console.WriteLine("//////////////////////////////////\n");
#endregion