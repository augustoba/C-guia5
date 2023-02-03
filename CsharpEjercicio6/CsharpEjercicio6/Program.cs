namespace CsharpEjercicio6
{
   /* 6. Crear un programa que dado un numero determine si es par o impar.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int num=int.Parse(Console.ReadLine());

            if (num % 2==0) {
                Console.WriteLine("el numero es par");
            }else {
                Console.WriteLine("el numero es impar");
            }
        }
    }
}