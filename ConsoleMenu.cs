using System;

namespace ConsoleMenu
{
    internal class ConsoleMenu
    {
        static void Main(string[] args)
        {
            const string CommandAnecdoteOne = "Anecdote 1";
            const string CommandAnecdoteTwo = "Anecdote 2";
            const string CommandRandom = "Random";
            const string CommandClear = "Clear";
            const string CommandListOfPgorgam = "Commands";
            const string CommandExit = "Exit";

            bool isWork = true;
            Random random = new Random();
            string listOfPrograms = $"Программа умеет выполнять следующие команды:\n\n" +
                $"{CommandAnecdoteOne} - Рассказать анекдот №1.\n\n" +
                $"{CommandAnecdoteTwo} - Рассказать анекдот №2.\n\n" +
                $"{CommandRandom} - Вывести случайное число.\n\n" +
                $"{CommandClear} - Очистить консоль.\n\n" +
                $"{CommandListOfPgorgam} - Повторить список команд, которые знает программа.\n\n" +
                $"{CommandExit} - Выход из программы.\n\n\n";

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Привет! Это моя первая программа. Она называется: 'Консольное меню'\n");

            Console.WriteLine(listOfPrograms);

            while (isWork)
            {
                Console.Write("Введите команду, которую хотите выполнить: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAnecdoteOne:
                        Console.WriteLine("\nПорой ты пытаешься показать свой богатый внутренний мир тому, у кого внутри посёлок городского типа.\n\n");
                        break;

                    case CommandAnecdoteTwo:
                        Console.WriteLine("\nПерейдём к действительно важным вопросам. Почему у Губки Боба нет зелёной шершавой штуки на спине?\n\n");
                        break;

                    case CommandRandom:
                        Console.Write("\nВведите нижнюю границу для случайного числа: ");
                        int minRandomNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nВведите верхнюю границу для случайного числа: ");
                        int manRandomNumber = Convert.ToInt32(Console.ReadLine());

                        int randomNumber = random.Next(minRandomNumber, manRandomNumber);

                        Console.WriteLine($"\nВаше случайное число: {randomNumber}\n\n");
                        break;

                    case CommandClear:
                        Console.Clear();
                        break;

                    case CommandListOfPgorgam:
                        Console.WriteLine("\n" + listOfPrograms);
                        break;

                    case CommandExit:
                        isWork = false;

                        Console.WriteLine("\nЗавершение программы . . .");
                        break;

                    default:
                        Console.WriteLine("\nИзвините, но пока что я такой команды не знаю.\n\nПопробуйте еще раз.\n");
                        break;
                }
            }
        }
    }
}
