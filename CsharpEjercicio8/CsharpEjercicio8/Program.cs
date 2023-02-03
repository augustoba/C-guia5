using System.Diagnostics;

namespace CsharpEjercicio8
{
   /* 8. Realizar un programa que solo permita introducir solo frases o palabras de 8 de largo.Si el
usuario ingresa una frase o palabra de 8 de largo se deberá de imprimir un mensaje por
pantalla que diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.
Nota: investigar la función Lenght() en Java.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese una frase  o palabra de 8 caracteres");
            string frase=Console.ReadLine();

            if (frase.Length == 8) { 
                Console.WriteLine("CORRECTO");
            }
            else
                {
                Console.WriteLine("incorrecto la longitud de la palabra es: " + frase.Length);
                }

            }
        }
    }
