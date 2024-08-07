using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        /*Crea un programa que calcule y muestre el promedio de una serie de números 
         * ingresados por el usuario utilizando un bucle for.*/
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese la cantidad de números
            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            int suma = 0;

            // Solicita al usuario que ingrese los números uno por uno
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;
            }

            // Calcula el promedio
            double promedio = (double)suma / cantidad;

            // Muestra el promedio
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
