using System;

namespace sumNumbers
{
    internal class sumNumbers
    {
        static void Main(string[] args)
        {
            int sumNumbers = 0;

            Random random = new Random();

            int number = random.Next(1, 101);

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumNumbers += i;
                }
            }

            Console.WriteLine($"Получено рандомное число: {number}.");
            Console.WriteLine($"Сумма всех положительных чисел меньше {number}, которые кратны 3 и 5 равна {sumNumbers}.");
        }
    }
}
