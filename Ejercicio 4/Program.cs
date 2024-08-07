using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*Escribe un programa que genere y muestre en la consola las tablas de multiplicar del 
     * 1 al 10 utilizando bucles for anidados.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Genera las tablas de multiplicar del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla de multiplicar del " + i + ":");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
                Console.WriteLine(); // Línea en blanco para separar cada tabla
            }

            // Espera a que el usuario presione una tecla antes de cerrar el programa
            Console.ReadKey();
        }
    }
}
