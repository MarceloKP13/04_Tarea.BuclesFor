using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tarea_BuclesFor
{
    internal class Program
    {
        /*Escribe un programa que imprima en la consola todos los números pares desde 1 hasta 100 utilizando un bucle for.*/
        static void Main(string[] args)
        {
            // Imprime todos los números pares desde 1 hasta 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
