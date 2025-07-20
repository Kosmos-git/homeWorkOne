using System;
using System.Reflection;
using System.Xml.Linq;

namespace localMaxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensionArray = 30;
            int[] array = new int[dimensionArray];
            int minValue = 10;
            int maxValue = 99;
            int indexFirstElement = 0;
            int indexLastElement = dimensionArray - 1;

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
                Console.Write(array[i] + " ");
            }

            Console.Write("\nЛокальные максимумы: ");

            if (array[indexFirstElement] > array[indexFirstElement + 1])
            {
                Console.Write(array[indexFirstElement] + " ");
            }

            for (int i = indexFirstElement + 1; i < indexLastElement; i++)
            {            
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[indexLastElement] > array[indexLastElement - 1])
            {
                Console.Write(array[indexLastElement] + " ");
            }
        }
    }
}
