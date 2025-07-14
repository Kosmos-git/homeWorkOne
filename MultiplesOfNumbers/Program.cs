using System;

namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minDivider = 10;
            int maxDivider = 25 + 1;
            int divider = random.Next(minDivider, maxDivider);
            int minValue = 50;
            int maxValue = 150;
            int multiplesNumbers = 0;

            Console.WriteLine("Дано N равное: " + divider);

            for (int i = 0; i <= maxValue; i += divider)
            {
                if (i >= minValue)
                {
                    multiplesNumbers++;
                }
            }

            Console.WriteLine($"Количество чисел от {minValue} до {maxValue}, которые кратны {divider}: {multiplesNumbers}");
        }
    }
}
