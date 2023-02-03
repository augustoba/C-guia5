namespace CsharpEjercicio13
{
    internal class Program
    {
        /*     13. Dibujar un cuadrado de N elementos por lado utilizando el carácter “*”. Por ejemplo, si el
     cuadrado tiene 4 elementos por lado se deberá dibujar lo siguiente:
     * * * *
     *     *
     *     *
     * * * *      

         */
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese el tamaño del cuadrado");
            int tamanio = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanio; i++)
            {
                for (int j = 0; j < tamanio; j++)
                {
                    if (i == 0 || j == 0 || i == tamanio - 1 || j == tamanio - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
