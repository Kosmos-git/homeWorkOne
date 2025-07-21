using System;

namespace dynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            int[] array = new int[0];
            bool isWork = true;
            int sum = 0;
            string userInput;
            int newLengthArray;

            while (isWork)
            {
                Console.Clear();

                Console.SetCursorPosition(0, 4);
                Console.WriteLine($"Введите число массива\n\n\n" +
                                  $"{CommandSum} - вывести сумму массива;\n" +
                                  $"{CommandExit} - выйти из программы.");

                Console.SetCursorPosition(0, 0);
                Console.Write("Массив: ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSum:
                        for (int k = 0; k < array.Length; k++)
                        {
                            sum += array[k];
                        }
                        Console.WriteLine("Сумма массива: " + sum);
                        sum = 0;
                        Console.ReadKey();
                        break;

                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Завершение программы...");
                        break;

                    default:
                        if (int.TryParse(userInput, out int elementArray))
                        {
                            newLengthArray = array.Length + 1;
                            int[] tempArray = new int[newLengthArray];

                            for (int j = 0; j < array.Length; j++)
                            {
                                tempArray[j] = array[j];
                            }

                            tempArray[newLengthArray - 1] = elementArray;
                            
                            array = tempArray;
                        }
                        else
                        {
                            Console.WriteLine("Введено не число и не известная команда");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
