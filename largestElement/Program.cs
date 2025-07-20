using System;

namespace largestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int minValue = 10;
            int maxValue = 99;
            int elementMax = int.MinValue;
            int elementInsteadMaximum = 0;

            Random random = new Random();

            Console.WriteLine("Исходная матрица:\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue + 1);

                    Console.Write(array[i, j] + " ");

                    if (elementMax < array[i, j])
                    {
                        elementMax = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nНаибольший элемент исходной матрицы: " + elementMax);
            Console.WriteLine("\nПолученная матрица:\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (elementMax == array[i, j])
                    {
                        array[i, j] = elementInsteadMaximum;
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
