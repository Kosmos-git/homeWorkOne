using System;

namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int N = random.Next(10, 26);
            int minValue = 50;
            int maxValue = 150;
            int multiplesNumbers = 0;

            Console.WriteLine("Дано N равное: " + N);

            for (int i = N; i <= maxValue; i += N)
            {
                if (i >= minValue && i <= maxValue)
                {
                    multiplesNumbers++;
                }
            }

            Console.WriteLine($"Количество чисел от {minValue} до {maxValue}, которые кратны {N}: {multiplesNumbers}");
        }
    }
}
