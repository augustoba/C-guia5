namespace CsharpEjercicio2
{
   /* 2. Escribir un programa que pida tu nombre, lo guarde en una variable y lo muestre por
pantalla.*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre");
            string nombre=Console.ReadLine();
            Console.WriteLine(nombre);
        }
    }
}