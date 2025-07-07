using System;

namespace sequence
{
    internal class sequence
    {
        static void Main(string[] args)
        {
            int initialTermProgression = 5;
            int differenceInProgression = 7;
            int memberOfProgression = initialTermProgression;
            int numberIterations;

            Console.Write("Введите количество членов прогрессии, которые Вас интересуют: ");
            numberIterations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberIterations; i++)
            {
                Console.Write(memberOfProgression + " ");
                memberOfProgression += differenceInProgression;
            }
        }
    }
}
