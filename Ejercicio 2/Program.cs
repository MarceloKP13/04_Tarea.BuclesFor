using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        /* Desarrolla un programa que calcule y muestre la suma de todos los números 
         * enteros positivos desde 1 hasta un número ingresado por el usuario utilizando un bucle for.*/
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número entero
            Console.Write("Ingrese un número entero: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;

            // Calcula la suma de todos los números enteros positivos desde 1 hasta n
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            // Muestra el resultado
            Console.WriteLine("La suma de todos los números enteros positivos desde 1 hasta " + n + " es: " + suma);

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
