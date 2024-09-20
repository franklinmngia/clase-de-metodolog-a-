using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int f, c; // f: filas, c: columnas
            Console.WriteLine("Ejemplo de los arreglos bidimensionales");
            Console.WriteLine("Digite los datos del arreglo:");

            // Lectura del arreglo
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Imprimiendo el arreglo...");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(" " + tabla1[f, c]);
                }
                Console.WriteLine("");
            }

            // Suma de las filas
            Console.WriteLine("\nSuma de las filas:");
            for (f = 0; f < 3; f++)
            {
                int sumaFila = 0;
                for (c = 0; c < 3; c++)
                {
                    sumaFila += tabla1[f, c];
                }
                Console.WriteLine("Suma de la fila " + (f + 1) + ": " + sumaFila);
            }

            // Suma de las columnas
            Console.WriteLine("\nSuma de las columnas:");
            for (c = 0; c < 3; c++)
            {
                int sumaColumna = 0;
                for (f = 0; f < 3; f++)
                {
                    sumaColumna += tabla1[f, c];
                }
                Console.WriteLine("Suma de la columna " + (c + 1) + ": " + sumaColumna);
            }

            Console.ReadKey();
        }
    }

}

