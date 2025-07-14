using System;

namespace powerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxValue = 1000;
            int numberInput = random.Next(maxValue);
            int minPowerTwo = 1;
            int powerOfNumber = 2;
            int valueOfNumber = 2;

            for (int i = valueOfNumber; i <= numberInput; i *= powerOfNumber)
            {
                minPowerTwo++;
                valueOfNumber = i * powerOfNumber;
            }

            Console.WriteLine($"Для числа {numberInput}, " +
                $"минимальная степень двойки, превышающая само число будет: {minPowerTwo}." +
                $"\nДвойка в степени {minPowerTwo}: {valueOfNumber}");
        }
    }
}
