using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*Crea un programa que imprima en la consola la serie de Fibonacci hasta el décimo término utilizando un bucle for.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Los primeros dos términos de la serie de Fibonacci
            int a = 0, b = 1;

            // Imprime los primeros dos términos
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Calcula y muestra los siguientes 8 términos de la serie de Fibonacci
            for (int i = 2; i < 10; i++)
            {
                int temp = a + b;
                Console.WriteLine(temp);
                a = b;
                b = temp;
            }

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
