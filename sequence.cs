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
            
            Console.Write("Введите начальный член прогрессии: ");
            initialTermProgression = Convert.ToInt32(Console.ReadLine());
            
            int memberOfProgression = initialTermProgression;

            Console.Write("Введите шаг прогрессии: ");
            differenceInProgression = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальный член прогрессии: ");
            maximumTermProgression = Convert.ToInt32(Console.ReadLine());

            while (memberOfProgression <= maximumTermProgression)
            {
                Console.Write(memberOfProgression + " ");
                memberOfProgression += differenceInProgression;
            }
        }
    }
}
