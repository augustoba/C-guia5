using System.Runtime.Intrinsics.X86;
using System;

namespace CsharpEjercicio5
{
  /*  5. Escribir un programa que lea un número entero por teclado y muestre por pantalla el
doble, el triple y la raíz cuadrada de ese número.Nota: investigar la función Math.sqrt().*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numer entero");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine("el doble del numero es: "+ (num*2));

            Console.WriteLine("el triple del numero es: " + (num * 3));

            Console.WriteLine("el raiz del numero es: " + (Math.Sqrt(num)));
        }
    }
}