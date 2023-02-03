using System.Diagnostics;

namespace CsharpEjercicio7
{
    internal class Program
    {
      /*  7. Crear un programa que pida una frase y si esa frase es igual a “eureka” el programa
pondrá un mensaje de Correcto, sino mostrará un mensaje de Incorrecto.Nota: investigar
la función equals() en Java. */
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese una frase");
            string frase= Console.ReadLine();
            if (frase == "eureka")
            {
                Console.WriteLine("correcto");
            }
            else
            {
                Console.WriteLine("incorrecto");
                      

            }
        }
    }
}