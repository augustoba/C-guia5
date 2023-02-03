using System.Net;

namespace CsharpEjercicio1
{

   /* 1. Escribir un programa que pida dos números enteros por teclado y calcule la suma de los
dos.El programa deberá después mostrar el resultado de la suma*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero.");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es: " + (num1 + num2));
        }
    }
}