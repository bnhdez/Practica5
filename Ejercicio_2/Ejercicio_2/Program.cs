using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ejer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte K, SW;
            string pass;
            SW = 0; K = 0;
            do
            {
                Console.Write("DIGITE CLAVE: "); pass = Console.ReadLine();
                if (pass == "contra123")
                {
                    SW = 1;
                }
                else
                {
                    K++;
                }
            } while (((K < 3) & (SW == 0)));
            if (SW == 1)
            {
                Console.WriteLine("BIENVENIDO ");
            }
            else
            {
                Console.WriteLine("OPORTUNIDADES TERMINADAS");
            }
        }
    }
}
