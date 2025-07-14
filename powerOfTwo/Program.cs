using System;

namespace powerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberInput = random.Next(100);
            int minPowerTwo = 0;
            int numberPowerTwo = 2;

            for (int i = numberPowerTwo; i < numberInput; i *= 2)
            {
                minPowerTwo++;
                numberPowerTwo = i;
            }

            minPowerTwo++;
            numberPowerTwo *= 2;

            Console.WriteLine($"Для числа {numberInput}, " +
                $"минимальная степень двойки, превышающая само число будет: {minPowerTwo}." +
                $"\n2 в степени {minPowerTwo}: {numberPowerTwo}");
        }
    }
}
