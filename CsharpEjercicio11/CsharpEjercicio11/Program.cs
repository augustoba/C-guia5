namespace CsharpEjercicio11
{
 /*  11. Realizar un programa que pida dos números enteros positivos por teclado y muestre por
pantalla el siguiente menú:

MENU
1. Sumar
2. Restar
3. Multiplicar
4. Dividir
5. Salir
Elija opción:

El usuario deberá elegir una opción y el programa deberá mostrar el resultado por pantalla
y luego volver al menú.El programa deberá ejecutarse hasta que se elija la opción 5.
Tener en cuenta que, si el usuario selecciona la opción 5, en vez de salir del programa
directamente, se debe mostrar el siguiente mensaje de confirmación: ¿Está seguro que
desea salir del programa (S/N)? Si el usuario selecciona el carácter ‘S’ se sale del
programa, caso contrario se vuelve a mostrar el menú. */
    internal class Program
    {
      
        private static void Main(string[] args)
        {

            Console.WriteLine("ingrese dos numeros");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());


            Console.WriteLine("---------MENU-------");
            Console.WriteLine("INGRESE UNA OPCION");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            
            int opc= int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: 
                    Console.WriteLine("la suma es: " + (num1+num2));
                        break;
                case 2:
                    Console.WriteLine("la resta es: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("la multiplicacion  es: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("la division es: " + (num1 / num2));
                    break;

                case 5:
                    Console.WriteLine("cerrando programa...");
                    break;
                default:
                    Console.WriteLine("ingreso una opcion incorrecta");
                    break;

            }
        }
    }
}