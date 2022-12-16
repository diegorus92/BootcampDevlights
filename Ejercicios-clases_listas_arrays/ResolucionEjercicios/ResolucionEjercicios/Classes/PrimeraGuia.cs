using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionEjercicios.Classes
{
    public class PrimeraGuia
    {
        public void mayorA(int entrada, int objetivo)
        {
            if (entrada > objetivo)
                Console.WriteLine("El valor ingresado es mayor a " + objetivo);
            else
                Console.WriteLine("El valor ingresado es menor a " + objetivo);
        }

        public bool esPar(int numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }

        public bool esDobleImpar(int numero)
        {
            if ((numero / 2) % 2 != 0) return true;
            else return false;
        }

        public string aRomano(int numero)
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

        public void elMenor()
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

        #region Ejercicio_6
        public string triangulo(float lado1, float lado2, float lado3)
        {
            if (lado1 == lado2 && lado1 == lado3)
                return "equilátero";
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                return "escaleno";
            else
                return "isósceles";
        }

        public float perimetro(float lado1, float lado2, float lado3)
        {
            return (lado1 + lado2 + lado3);
        }

        public float area(float lado1, float lado2)
        {
            return ((lado1 * lado2) / 2);
        }
        #endregion

        public void desglosar(int monto)
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

            while (monto >= 1000)
            {
                contMil++;
                monto -= 1000;
            }

            while (monto >= 500)
            {
                contQuinientos++;
                monto -= 500;
            }

            while (monto >= 100)
            {
                contCien++;
                monto -= 100;
            }

            while (monto >= 50)
            {
                contCincuenta++;
                monto -= 50;
            }

            while (monto >= 20)
            {
                contVeinte++;
                monto -= 20;
            }

            while (monto >= 10)
            {
                contDIez++;
                monto -= 10;
            }

            while (monto >= 5)
            {
                contCinco++;
                monto -= 5;
            }

            while (monto >= 2)
            {
                contDos++;
                monto -= 2;
            }

            while (monto >= 1)
            {
                contUno++;
                monto -= 1;
            }

            Console.WriteLine(
                "1000 = " + contMil +
                "\n500 = " + contQuinientos +
                "\n100 = " + contCien +
                "\n50 = " + contCincuenta +
                "\n20 = " + contVeinte +
                "\n10 = " + contDIez +
                "\n5 = " + contCinco +
                "\n2 = " + contDos +
                "\n1 = " + contUno);
        }

        public void deUnoAN()
        {
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        public int sumatoria()
        {
            int acumulador = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("\n" + (i + 1) + "=> Ingrese un número: ");
                acumulador += int.Parse(Console.ReadLine());
            }
            return acumulador;
        }

        public void multiploDeTres()
        {
            int numero;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa un número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 3 == 0)
                    Console.WriteLine("El número " + numero + " es multiplo de 3\n");
            }
        }

        public void comprobarPassword(string passOriginal)
        {
            string entrada;
            do
            {
                Console.Write("Vuelva a ingresar la contraseña: ");
                entrada = Console.ReadLine();
                if (entrada != passOriginal)
                    Console.WriteLine("Las contraseñas no coinciden!");
            } while (entrada != passOriginal);
            Console.WriteLine("FELICIDADES! Las contraseñas coinciden :)");
        }

        public void comprobarPasswordConLimite(string passOriginal, int intentos)
        {
            string entrada;

            for (int i = intentos; i > 0; i--)
            {
                Console.Write("Vuelva a ingresar la contraseña(" + i + " intentos): ");
                entrada = Console.ReadLine();
                if (entrada == passOriginal)
                {
                    Console.WriteLine("FELICIDADES! Las contraseñas coinciden :)");
                    break;
                }
                Console.WriteLine("Contraseña incorrecta");
            }
            Console.WriteLine("Fin de la aplicación");
        }

        public void adivinarNumero(int numero)
        {
            int entrada;
            do
            {
                Console.Write("Adivine el número: ");
                entrada = int.Parse(Console.ReadLine());
                if (entrada != numero)
                    Console.WriteLine("No es el número, vuelve a intentarlo.\n");
            } while (entrada != numero);
            Console.WriteLine("Acertaste!!! :D");
        }

        public void adivinarNumeroConPistas(int numero)
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

        public void sumatoria2(string condicionFin)
        {
            int acumulador = 0;
            string entrada = "";

            while (entrada != condicionFin)
            {
                Console.Write("Ingrese un numero para sumar o escriba '" + condicionFin + "' para terminar: ");
                entrada = Console.ReadLine();
                if (entrada != condicionFin)
                {
                    acumulador += int.Parse(entrada);
                }
            }

            Console.WriteLine("Resultado final de la sumatoria: " + acumulador);
        }

    }
}
