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

            string stringOfCharacters = "";
            string stringWithName;
            
            stringWithName = symbolOutput + name + symbolOutput;

            for (int i = 0; i < stringWithName.Length; i++)
            {
                stringOfCharacters += symbolOutput;
            }

            Console.WriteLine(stringOfCharacters);
            Console.WriteLine(stringWithName);
            Console.WriteLine(stringOfCharacters);
        }
    }
}