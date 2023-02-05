using System.Diagnostics;

namespace CsharpEjercicio3
{
   /* 3. Escribir un programa que pida una frase y la muestre toda en mayúsculas y después toda
en minúsculas.Nota: investigar la función toUpperCase() y toLowerCase() en Java.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese una frase");
            string frase = Console.ReadLine();
            Console.WriteLine(frase.ToLower());
           

        }
    }
}