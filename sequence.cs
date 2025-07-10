using System;

namespace sequence
{
    internal class sequence
    {
        static void Main(string[] args)
        {
            int initialTermProgression;
            int differenceInProgression;
            int maximumTermProgression;
            int elementsProgression;


            Console.Write("Введите начальный член прогрессии: ");
            initialTermProgression = Convert.ToInt32(Console.ReadLine());

            int memberOfProgression = initialTermProgression;

            Console.Write("Введите шаг прогрессии: ");
            differenceInProgression = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число элементов прогрессии: ");
            elementsProgression = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elementsProgression; i++)
            {
                Console.Write(memberOfProgression + " ");
                memberOfProgression += differenceInProgression;
            }
        }
    }
}
