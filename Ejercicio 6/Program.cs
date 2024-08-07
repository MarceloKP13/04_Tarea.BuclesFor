using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        /*Escribe un programa que busque un elemento específico dentro de un arreglo de
         *números utilizando un bucle for y muestre un mensaje indicando si el elemento fue encontrado o no.*/
        static void Main(string[] args)
        {
            // Arreglo de números
            int[] numeros = { 3, 7, 1, 14, 9, 21, 2, 18 };

            // Solicita al usuario que ingrese el número a buscar
            Console.Write("Ingrese el número a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            // Busca el número en el arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    encontrado = true;
                    break;
                }
            }

            // Muestra un mensaje indicando si el número fue encontrado o no
            if (encontrado)
            {
                Console.WriteLine("El número " + buscado + " fue encontrado en el arreglo.");
            }
            else
            {
                Console.WriteLine("El número " + buscado + " no fue encontrado en el arreglo.");
            }

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
