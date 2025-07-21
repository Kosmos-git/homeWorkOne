using System;

namespace localMaxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthaSequenceNumbers = 30;
            int[] sequenceNumbers = new int[lengthaSequenceNumbers];
            int minValue = 10;
            int maxValue = 99;

            Random random = new Random();

            for (int i = 0; i < sequenceNumbers.Length; i++)
            {
                sequenceNumbers[i] = random.Next(minValue, maxValue + 1);
                Console.Write(sequenceNumbers[i] + " ");
            }

            Console.Write("\nЛокальные максимумы: ");

            if (sequenceNumbers[0] > sequenceNumbers[1])
            {
                Console.Write(sequenceNumbers[1] + " ");
            }

            for (int i = 1; i < sequenceNumbers.Length; i++)
            {            
                if (sequenceNumbers[i] > sequenceNumbers[i - 1] && sequenceNumbers[i] > sequenceNumbers[i + 1])
                {
                    Console.Write(sequenceNumbers[i] + " ");
                }
            }

            if (sequenceNumbers[sequenceNumbers.Length] > sequenceNumbers[sequenceNumbers.Length - 1])
            {
                Console.Write(sequenceNumbers[sequenceNumbers.Length] + " ");
            }
        }
    }
}
