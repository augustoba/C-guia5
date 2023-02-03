using System.Diagnostics;

namespace CsharpEjercicio9
{
    internal class Program
    {
      /*  9. Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase
es una ‘A’. Si la primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla que
diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”. Nota: investigar
la función Substring y equals() de Java.*/
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese una frase o palabra");
            string frase=Console.ReadLine();

            if (frase.Substring(0,1).Equals("A")){
                Console.WriteLine("Correcto");

            }
            else { 
                Console.WriteLine("INCORRECTO"); }
        }
    }
}