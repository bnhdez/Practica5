using System;
using System.Collections.Generic;
using System.Text;
namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0; 
            string valor = "";
            // Mostramos el menu
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            // Pedimos la opcion
            Console.WriteLine("Cual es tu opcion:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            // Checamos por la suma
            if (opcion == 1)
            {
                Suma();
            }
            // Checamos por la resta
            if (opcion == 2)
            {
                // Variable para nuestro resultado
                float resultado = 0;
                // Invocamos y obtenemos el resultado
                resultado = Resta();
                // Mostramos el resultado
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }
            // Checamos por la multiplicacion
            if (opcion == 3)
            {
                // Variables necesarias
                float n1 = 0;
                float n2 = 0;
                // Pedimos los valores
                n1 = PideFlotante("Dame el primer numero");
                n2 = PideFlotante("Dame el segundo numero");
                // Invocamos a la funcion
                Multiplicacion(n1, n2);
            }
            // Checamos por la division
            if (opcion == 4)
            {
                // Variables necesarias
                float n1 = 0.0f;
                float n2 = 0.0f;
                float resultado = 0.0f;
                // Pedimos los valores
                n1 = PideFlotante("Dame el primer numero");
                n2 = PideFlotante("Dame el segundo numero");
                // Invocamos a la funcion
                resultado = Division(n1, n2);
                // Mostramos el resultado
                Console.WriteLine("El resultado es {0}", resultado);
            }
        }
        // Cierre de Main
        static void Suma()
        {
            // Variables necesarias
            float a = 0;
            float b = 0;
            float r = 0;
            // Pedimos los valores
            a = PideFlotante("Dame el primer numero");
            b = PideFlotante("Dame el segundo numero");
            // Calculamos el resultado
            r = a + b;
            // Mostramos el resultado
            Console.WriteLine("El resultado es {0}", r);
        }
        static float Resta()
        {
            // Variables necesarias
            float a = 0;
            float b = 0;
            float r = 0;
            // Pedimos los valores
            a = PideFlotante("Dame el primer numero");
            b = PideFlotante("Dame el segundo numero");
            // Calculamos el resultado
            r = a - b;
            // Retornamos el resultado
            return r;
        }
        static void Multiplicacion(float a, float b)
        {
            // Variables necesarias
            float r = 0;
            // Calculamos el valor
            r = a * b;
            // Mostramos el resultado
            Console.WriteLine("El resultado es {0}", r);
        }
        static float Division(float a, float b)
        {
            // Variables necesarias
            float r = 0;
            // Verificamos por division entre cero
            if (b == 0)
            {
                Console.WriteLine("No es posible dividir entre cero");
                return 0.0f;
            }
            else
            {
                r = a / b; return r;
            }
        }
        static float PideFlotante(string mensaje)
        {
            // Variables necesarias
            float numero = 0.0f;
            string valor = "";
            // Mostramos el mensaje
            Console.WriteLine(mensaje);
            // Obtenemos el valor
            valor = Console.ReadLine();
            numero = Convert.ToSingle(valor);
            // Regresamos el dato
            return numero;
        }
    }
}

