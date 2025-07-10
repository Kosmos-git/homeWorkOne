using System;
using System.Threading;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNumbers = 0;
            int multiplicityCheckNo1 = 3;
            int multiplicityCheckNo2 = 5;
            int numberMaximum = 100;
            int numberMinimum = 1;

            Random random = new Random();
                        
            int number = random.Next(numberMinimum, numberMaximum + 1);

            for (int i = 0; i <= number; i++)
            {
                if (i % multiplicityCheckNo1 == 0 || i % multiplicityCheckNo2 == 0)
                {
                    sumNumbers += i;
                }
            }

            Console.WriteLine($"Получено рандомное число: {number}.");
            Console.WriteLine($"Сумма всех положительных чисел меньше {number}, которые " +
                $"кратны {multiplicityCheckNo1} и {multiplicityCheckNo2} равна {sumNumbers}.");
        }
    }
}
