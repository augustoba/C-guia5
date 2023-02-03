namespace CsharpEjercicio10
{
    internal class Program
    {
       /* 10. Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación solicite
números al usuario hasta que la suma de los números introducidos supere el límite inicial.*/
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor limite positivo");

            int valorMax= int.Parse(Console.ReadLine());
            int total=0;
            do{
                Console.WriteLine("ingrese un numero");
                int num= int.Parse(Console.ReadLine());
                total = total + num;

            } while (total <valorMax);

            Console.WriteLine("la suma alcanzo el valor limite: " + total) ; 
        }
    }
}