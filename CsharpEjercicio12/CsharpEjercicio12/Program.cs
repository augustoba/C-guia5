﻿
namespace CsharpEjercicio12
{
    /*   12. Realizar un programa que simule el funcionamiento de un dispositivo RS232, este tipo de
   dispositivo lee cadenas enviadas por el usuario.Las cadenas deben llegar con un formato
   fijo: tienen que ser de un máximo de 5 caracteres de largo, el primer carácter tiene que ser
   X y el último tiene que ser una O.
   Las secuencias leídas que respeten el formato se consideran correctas, la secuencia
   especial “&&&&&” marca el final de los envíos (llamémosla FDE), y toda secuencia distinta
   de FDE, que no respete el formato se considera incorrecta.
   Al finalizar el proceso, se imprime un informe indicando la cantidad de lecturas correctas e
   incorrectas recibidas.Para resolver el ejercicio deberá investigar cómo se utilizan las
   siguientes funciones de Java Substring(), Length(), equals().*/
    internal class Program
    {
        private static void Main(string[] args)
        {
            string cadena;



            int contCorrecta = 0;
            int contIncorrecta = 0;
            do
            {
                Console.WriteLine("ingrese la cadena de caracteres");
                cadena = Console.ReadLine();
                int tamanioCad = cadena.Length;

                if (cadena.Equals("&&&&&"))
                {


                }
                else if (cadena.Length <= 5 && cadena.Substring(0, 1) == "X" && cadena.EndsWith("O"))

                {
                    contCorrecta++;

                }
                else
                {
                    contIncorrecta++;

                }

            } while (!cadena.Equals("&&&&&"));

            Console.WriteLine("se ingresaron " + contCorrecta + " codigos correctos\n "
                  + "se ingresaron " + contIncorrecta + " codigos incorrectos");

        }

    }
}
