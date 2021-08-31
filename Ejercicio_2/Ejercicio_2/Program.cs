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
            int intentos = 0, verif = 0;
            string pass;
            do
            {
                Console.Write("DIGITE CLAVE: "); pass = Console.ReadLine();
                if (pass == "contra123")
                {
                    verif = 1;
                }
                else
                {
                    intentos++;
                }
            //aumentara el numero de intentos si no es correcta la contraseña
            } while (((intentos < 3) & (verif == 0)));
            if (verif == 1)
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
