using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
                //metodo para verificar si es entero positivo
                verificar(num);
            } while (num < 0);
            //metodo para calcular factorial
            factorial(num);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo...\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            //aumenta la variable i hasta llegar a n, mientras se multiplica a si misma
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}
