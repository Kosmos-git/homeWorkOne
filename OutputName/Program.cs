using System;

namespace OutputName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbolOutput;
            string name;

            Console.Write("Введите символ: ");
            symbolOutput = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            
            Console.WriteLine();

            int lengthBox = name.Length + 1;
            int heightBox = 3;
            int stringName = 1;
            int threeConclusions = 3;
            int outputName = 1;

            for (int i = 0; i < heightBox; i++)
            {
                if (i != stringName)
                {
                    for (int j = 0; j <= lengthBox; j++)
                    {
                        Console.Write(symbolOutput);
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < threeConclusions; k++)
                    {
                        if (k != outputName)
                        {
                            Console.Write(symbolOutput);
                        }
                        else
                        {
                            Console.Write(name);
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}