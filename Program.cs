using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar un menu con las posibles opciones
            /*
             * 1. Suma
             * 2. Resta
             * .... Cuadrado
             * .... Raiz Cuadrada
             */
            
        Console.WriteLine("Por favor agrege la operación que desea realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Cuadrado");
            Console.WriteLine("6. Raiz Cuadrada");

            int operation = Int32.Parse(Console.ReadLine());
            

            while (operation <=0 || operation >=7 ) {
                Console.WriteLine("La información ingresada no es correcta, por favor ingrese una operación");
                operation = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el primer valor");
            double number1 = double.Parse(Console.ReadLine());
            double number2;

            if (operation == 5 || operation == 6)
            {

                number2 = 0;

            }
            else {
                Console.WriteLine("Ingrese el segundo valor");
                number2 = double.Parse(Console.ReadLine());
            }

            

            Operations opera = new Operations(number1, number2, operation);
        }
    }
}