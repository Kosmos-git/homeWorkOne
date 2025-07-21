using System;
using System.Reflection;

namespace localMaxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthaNumbers = 30;
            int[] numbers = new int[lengthaNumbers];
            int minValue = 10;
            int maxValue = 99;
            int indexLastNumber = numbers.Length - 1;

            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\nЛокальные максимумы: ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {            
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[numbers.Length - 1] > numbers[indexLastNumber - 1])
            {
                Console.Write(numbers[numbers.Length - 1] + " ");
            }
        }
    }
}
