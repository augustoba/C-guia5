namespace CsharpEjercicio4
{
    /*4. Dada una cantidad de grados centígrados se debe mostrar su equivalente en grados
Fahrenheit.La fórmula correspondiente es: F = 32 + (9 * C / 5).*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese grados centrigrados.");
            int gradosC=int.Parse(Console.ReadLine());
            Console.WriteLine("los grados centigrados ingresados son igual a :" + (32 + (gradosC * 1.8)));
        }
    }
}